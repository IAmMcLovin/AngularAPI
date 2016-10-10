CREATE TABLE [dbo].[Image] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [Full]      NVARCHAR (1000) NULL,
    [ProductId] INT             NOT NULL,
    CONSTRAINT [pk_Image] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [fk_Image] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id]) ON DELETE CASCADE
);

