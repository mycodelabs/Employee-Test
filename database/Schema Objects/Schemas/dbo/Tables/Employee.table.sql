CREATE TABLE [dbo].[Employee] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    [Email]      VARCHAR (50) NOT NULL,
    [JobTitleId] INT          NOT NULL
);

