﻿CREATE TABLE [dbo].[ARM]
(
	[ID] INT NOT NULL identity(1,1), 
    [ARM_Name] varchar(63) NOT NULL
)
GO

ALTER TABLE [dbo].[ARM] ADD CONSTRAINT PK_ARM_ID PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
GO

