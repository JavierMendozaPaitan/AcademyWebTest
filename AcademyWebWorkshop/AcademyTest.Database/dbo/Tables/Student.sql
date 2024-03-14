CREATE TABLE [dbo].[Student] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [StudentName]    NVARCHAR (100) NULL,
    [Email]          NVARCHAR (100) NULL,
    [StudentLevelId] INT            NULL,
    [CreateDate]     DATE           NULL,
    [ModifiedDate]   DATE           NULL,
    CONSTRAINT [pk_student_Id] PRIMARY KEY CLUSTERED ([Id] ASC)
);

