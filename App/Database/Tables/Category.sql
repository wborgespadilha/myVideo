﻿CREATE TABLE [Video].[Category]
(
	[CategoryID] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NULL, 
    [CreatedAt] DATETIME NOT NULL DEFAULT GETDATE(), 
    [CreatedBy] INT NOT NULL DEFAULT 0, 
    [ModifiedAt] DATETIME NOT NULL DEFAULT GETDATE(), 
    [ModifiedBy] INT NOT NULL DEFAULT 0
)
