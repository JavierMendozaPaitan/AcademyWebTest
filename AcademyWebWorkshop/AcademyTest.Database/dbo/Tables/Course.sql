CREATE TABLE [dbo].[Course] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [CourseName]   NVARCHAR (100) NULL,
    [Description]  NVARCHAR (100) NULL,
    [TeacherId]    INT            NULL,
    [StartDate]    DATE           NULL,
    [EndDate]      DATE           NULL,
    [CreateDate]   DATE           NULL,
    [ModifiedDate] DATE           NULL,
    CONSTRAINT [pk_Course_Id] PRIMARY KEY CLUSTERED ([Id] ASC)
);

