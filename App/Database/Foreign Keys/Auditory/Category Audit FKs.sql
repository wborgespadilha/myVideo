ALTER TABLE [Video].[Category]
	ADD CONSTRAINT [FK_Category_CreatedBy_User]
	FOREIGN KEY (CreatedBy)
	REFERENCES [Audit].[User] (UserID); 
	
GO

ALTER TABLE [Video].[Category]
	ADD CONSTRAINT [FK_Category_ModifiedBy_User]
	FOREIGN KEY (ModifiedBy)
	REFERENCES [Audit].[User] (UserID);