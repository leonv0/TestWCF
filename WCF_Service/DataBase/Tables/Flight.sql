CREATE TABLE [dbo].[Flight]
(
	[ID] BIGINT NOT NULL,
	[Flight_Number_ID] INT NOT NULL,
	[Flight_Date] date NOT NULL,
	[Estimate_Arrival] datetime NULL,
	[Arrival] datetime NULL
)
GO

ALTER TABLE [dbo].[Flight] ADD CONSTRAINT PK_Flight_ID PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Flight]
   ADD CONSTRAINT FK_Flight_Flight_Number FOREIGN KEY (Flight_Number_ID)
      REFERENCES [dbo].[Flight_Number] (ID)
GO