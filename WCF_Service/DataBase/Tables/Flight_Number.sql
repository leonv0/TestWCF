CREATE TABLE [dbo].[Flight_Number]
(
	[ID] INT NOT NULL identity(1,1), 
    [Flight_Number] varchar(128) NOT NULL,
	[Flight_Sheduled_Time] TIME(0) NULL
)
GO
ALTER TABLE [dbo].[Flight_Number] ADD CONSTRAINT PK_Flight_Number_ID PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
GO

CREATE UNIQUE NONCLUSTERED INDEX [NonClusteredIndex_Flight_Number_Flight_Sheduled_Time] ON [dbo].[Flight_Number]
(
	[Flight_Number] ASC,
	[Flight_Sheduled_Time] ASC
)
GO

