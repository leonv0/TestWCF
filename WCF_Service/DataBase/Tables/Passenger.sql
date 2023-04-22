CREATE TABLE [dbo].[Passenger]
(
	[ID] BIGINT NOT NULL, 
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