ALTER TABLE [dbo].[Employee]
    ADD CONSTRAINT [JobTitle.ForeignKeyConstraint] FOREIGN KEY ([JobTitleId]) REFERENCES [dbo].[JobTitle] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

