CREATE TABLE [dbo].[StudentLevel] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [LevelName]    NVARCHAR (50)  NULL,
    [Description]  NVARCHAR (100) NULL,
    [CreateDate]   DATE           NULL,
    [ModifiedDate] DATE           NULL,
    CONSTRAINT [pk_StudentLevel_Id] PRIMARY KEY CLUSTERED ([Id] ASC)
);

