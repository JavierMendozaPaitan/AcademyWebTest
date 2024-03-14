CREATE TABLE [dbo].[StudentCourse] (
    [Id]           INT  IDENTITY (1, 1) NOT NULL,
    [StudentId]    INT  NOT NULL,
    [CourseId]     INT  NOT NULL,
    [CreateDate]   DATE NULL,
    [ModifiedDate] DATE NULL,
    CONSTRAINT [pk_StudentCourse_Id] PRIMARY KEY CLUSTERED ([Id] ASC)
);

