CREATE TABLE [dbo].[Book]
(
	[BookId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NCHAR(40) NULL, 
    [Ganre] NCHAR(10) NULL, 
    [NamPage] INT NULL, 
    [FkAthor] UNIQUEIDENTIFIER NULL, 
    CONSTRAINT [FK_Table_Athor] FOREIGN KEY ([FkAthor]) REFERENCES [Athor]([AthorId])
)
