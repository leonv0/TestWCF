CREATE TABLE [dbo].[Flight]
(
	[ID] BIGINT NOT NULL identity(1,1),
	[Flight_Number_ID] INT NOT NULL,
	[Flight_Sheduled_Date] date NOT NULL,
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

CREATE UNIQUE NONCLUSTERED INDEX [NonClusteredIndex_Flight_Number_ID_Flight_Sheduled_Date] ON [dbo].[Flight]
(
	[Flight_Number_ID] ASC,
	[Flight_Sheduled_Date] ASC
)
GO