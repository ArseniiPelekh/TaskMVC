CREATE TABLE [dbo].[Athor] (
    [AthorId]    UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [Name]       NCHAR (20) NULL,
    [Surname]    NCHAR (20) NULL,
    [MiddleName] NCHAR (20) NULL,
    [Phone]      NCHAR (10) NULL,
    [Birthday]   DATETIME   NULL,
    PRIMARY KEY CLUSTERED ([AthorId] ASC)
);

