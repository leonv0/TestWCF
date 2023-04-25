CREATE PROCEDURE [dbo].[SavePerson]
	@Flight_Number varchar(128),
    @Flight_Sheduled_Time  time(0),
    @Flight_Sheduled_Date date,
    @Estimate_Arriva datetime NULL,
    @Arrival datetime NULL,
    @Name varchar(128) NULL,
    @Reservation_Number varchar(14) NULL,
    @DocumentNumber nchar(36) NULL
AS
BEGIN
    if object_id('tempdb..NumTempTable') is not null drop table #NumTempTable
    CREATE TABLE #NumTempTable (ID bigint not null,[ACT] varchar(32) not null)

        BEGIN
            MERGE 
            INTO [Flight_Number] fn
            USING (
            SELECT 
                @Flight_Number,@Flight_Sheduled_Time 
               ) i ([Flight_Number],[Flight_Sheduled_Time])
            ON 
                fn.[Flight_Number] = i.[Flight_Number] 
                and fn.[Flight_Sheduled_Time] = i.[Flight_Sheduled_Time]
                --WHEN MATCHED THEN
                --UPDATE SET Name = src.Name  
            WHEN NOT MATCHED THEN  
                INSERT ([Flight_Number], [Flight_Sheduled_Time])
                VALUES (i.[Flight_Number], i.[Flight_Sheduled_Time]);  
        END
        BEGIN
            MERGE 
            INTO [Flight] f
            USING (
                SELECT fn.ID,@Flight_Sheduled_Date,@Estimate_Arriva,@Arrival
                    FROM [Flight_Number] fn 
                        WHERE
                    fn.Flight_Number = @Flight_Number AND fn.Flight_Sheduled_Time = @Flight_Sheduled_Time 
                    ) i ([Flight_Number_ID],[Flight_Sheduled_Date],[Estimate_Arrival],[Arrival])
            ON 
            f.[Flight_Number_ID] = i.[Flight_Number_ID]
            and f.[Flight_Sheduled_Date] = i.[Flight_Sheduled_Date]
            WHEN MATCHED THEN
              UPDATE SET [Estimate_Arrival] = i.[Estimate_Arrival], [Arrival] = i.[Arrival] 
            WHEN NOT MATCHED THEN  
            INSERT ([Flight_Number_ID],[Flight_Sheduled_Date],[Estimate_Arrival],[Arrival])
            VALUES (i.[Flight_Number_ID],i.[Flight_Sheduled_Date],i.[Estimate_Arrival],i.[Arrival])
            OUTPUT inserted.[ID], $action as [Act] INTO #NumTempTable; 
        END

        BEGIN
            MERGE 
            INTO [Passenger] p
            USING (
                SELECT n.ID,@Name,@Reservation_Number,@DocumentNumber
                    FROM #NumTempTable n 
                    ) i ([Flight_ID],[Name],[Reservation_Number],[DocumentNumber])
            ON 
            p.[Flight_ID] = i.[Flight_ID]
            and p.[Name] = @Name
            WHEN MATCHED THEN
              UPDATE SET [Reservation_Number] = i.[Reservation_Number], [DocumentNumber] = i.[DocumentNumber] 
            WHEN NOT MATCHED THEN  
            INSERT ([Flight_ID],[Name],[Reservation_Number],[DocumentNumber])
            VALUES (i.[Flight_ID],i.[Name],i.[Reservation_Number],i.[DocumentNumber]);
        END



        drop table #NumTempTable
    RETURN 0
END
GO
