CREATE TABLE [dbo].[Passenger]
(
	[ID] BIGINT NOT NULL identity(1,1), 
    [Flight_ID] BIGINT NOT NULL, 
    [Name] VARCHAR(128) NULL, 
    [Reservation_Number] VARCHAR(14) NULL, 
    [DocumentNumber] NCHAR(36) NULL
)
GO

ALTER TABLE [dbo].[Passenger] ADD CONSTRAINT PK_Passenger_ID PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Passenger]
   ADD CONSTRAINT FK_Passenger_Flight FOREIGN KEY (Flight_ID)
      REFERENCES [dbo].[Flight] (ID)
GO

CREATE UNIQUE NONCLUSTERED INDEX [NonClusteredIndex_Flight_ID_Name] ON [dbo].[Passenger]
(
	[Flight_ID] ASC,
	[Name] ASC
)
GO