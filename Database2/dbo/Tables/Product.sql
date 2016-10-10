CREATE TABLE [dbo].[Product] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [name]        NVARCHAR (1000) NULL,
    [price]       MONEY           NULL,
    [Description] NTEXT           NULL,
    CONSTRAINT [pk_Product] PRIMARY KEY CLUSTERED ([Id] ASC)
);

