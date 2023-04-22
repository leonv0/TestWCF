﻿CREATE TABLE [dbo].[Session]
(
	[ID] BIGINT NOT NULL, 
    [Login] VARCHAR(256) NOT NULL, 
    [ARM_ID] INT NOT NULL, 
    [StartTime] DATETIME NOT NULL, 
    [EndTime] DATETIME NULL
)
GO
ALTER TABLE [dbo].[Session] ADD CONSTRAINT PK_StatrtSession_ID PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Session]
   ADD CONSTRAINT FK_StatrtSession_ARM FOREIGN KEY (ARM_ID)
      REFERENCES [dbo].[ARM] (ID)
GO