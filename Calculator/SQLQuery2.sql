CREATE TABLE [dbo].[Subscription]
(
    [Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NULL,
  [Price] FLOAT NULL,
  [Limit] INT NULL
)

CREATE TABLE [dbo].[UserSubs]
(
    [Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] BIGINT NOT NULL,
  [SubsId] BIGINT NOT NULL,
  CONSTRAINT [FK_UserSubs1] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id]),
  CONSTRAINT [FK_UserSubs2] FOREIGN KEY ([SubsId]) REFERENCES [dbo].[Subscription] ([Id])
)

CREATE TABLE [dbo].[SubsOperations]
(
    [Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
  [SubsId] BIGINT NOT NULL,
  [OperationId] BIGINT NOT NULL,
  CONSTRAINT [FK_SubsOperations1] FOREIGN KEY ([OperationId]) REFERENCES [dbo].[Operation] ([Id]),
  CONSTRAINT [FK_SubsOperations2] FOREIGN KEY ([SubsId]) REFERENCES [dbo].[Subscription] ([Id])
)