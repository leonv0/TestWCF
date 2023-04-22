CREATE TABLE [dbo].[Registration]
(
	[ID] BIGINT NOT NULL identity(1,1),
	[Session_ID] BIGINT NULL,
	[First_Name] varchar(128) NULL,
	[Last_Name] varchar(128) NULL,
	[Flight_Number] varchar(128) NOT NULL,
	[Flight_Time] varchar(128) NOT NULL,
	[Laggage_Count] smallint NULL
)
GO

ALTER TABLE [dbo].[Registration] ADD CONSTRAINT PK_Registration_ID PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Registration]
   ADD CONSTRAINT FK_Registration_Session FOREIGN KEY (Session_ID)
      REFERENCES [dbo].[Session] (ID)
GO