ALTER TABLE [Video].[Video]
	ADD CONSTRAINT [FK_Video_CreatedBy_User]
	FOREIGN KEY (CreatedBy)
	REFERENCES [Auditory].[User] (UserID);

GO

ALTER TABLE [Video].[Video]
	ADD CONSTRAINT [FK_Video_ModifiedBy_User]
	FOREIGN KEY (ModifiedBy)
	REFERENCES [Auditory].[User] (UserID);