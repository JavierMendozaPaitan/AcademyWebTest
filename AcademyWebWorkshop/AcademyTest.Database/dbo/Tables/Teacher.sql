CREATE TABLE [dbo].[Teacher] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [TeacherName]  NVARCHAR (100) NULL,
    [Email]        NVARCHAR (100) NULL,
    [CreateDate]   DATE           NULL,
    [ModifiedDate] DATE           NULL,
    CONSTRAINT [pk_Teacher_Id] PRIMARY KEY CLUSTERED ([Id] ASC)
);

