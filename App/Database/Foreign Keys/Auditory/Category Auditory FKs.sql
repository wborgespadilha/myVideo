ALTER TABLE [Video].[Category]
	ADD CONSTRAINT [FK_Category_CreatedBy_User]
	FOREIGN KEY (CreatedBy)
	REFERENCES [Auditory].[User] (UserID); 
	
GO

ALTER TABLE [Video].[Category]
	ADD CONSTRAINT [FK_Category_ModifiedBy_User]
	FOREIGN KEY (ModifiedBy)
	REFERENCES [Auditory].[User] (UserID);