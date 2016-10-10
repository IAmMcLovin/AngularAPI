CREATE TABLE [dbo].[Review] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [Author]    NVARCHAR (500)  NULL,
    [stars]     NVARCHAR (1000) NULL,
    [body]      NTEXT           NULL,
    [ProductId] INT             NOT NULL,
    CONSTRAINT [pk_Review] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [fk_Review] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id]) ON DELETE CASCADE
);

