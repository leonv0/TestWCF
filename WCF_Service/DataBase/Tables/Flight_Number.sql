CREATE TABLE [dbo].[Flight_Number]
(
	[ID] INT NOT NULL, 
    [Flight_Number] varchar(128) NOT NULL,
	[Flight_Sheduled_Time] TIME(0) NULL
)
GO
ALTER TABLE [dbo].[Flight_Number] ADD CONSTRAINT PK_Flight_Number_ID PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
GO