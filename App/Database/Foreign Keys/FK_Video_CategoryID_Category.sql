ALTER TABLE [Video].[Video]
	ADD CONSTRAINT [FK_Video_CategoryID_Category]
	FOREIGN KEY (CategoryID)
	REFERENCES [Video].[Category] (CategoryID)
