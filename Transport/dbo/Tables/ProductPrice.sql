CREATE TABLE [dbo].[ProductPrice] (
    [IdPrice]   INT  NOT NULL,
    [Price]     REAL NOT NULL,
    [IdDate]    INT  NOT NULL,
    [IdProduct] INT  NOT NULL,
    [IdStore]   INT  NOT NULL,
    CONSTRAINT [PK_ProductPrice] PRIMARY KEY CLUSTERED ([IdPrice] ASC),
    CONSTRAINT [FK_ProductPrice_Dates] FOREIGN KEY ([IdDate]) REFERENCES [dbo].[Dates] ([IdDate]),
    CONSTRAINT [FK_ProductPrice_Products] FOREIGN KEY ([IdProduct]) REFERENCES [dbo].[Products] ([IdProduct]),
    CONSTRAINT [FK_ProductPrice_Stores] FOREIGN KEY ([IdStore]) REFERENCES [dbo].[Stores] ([IdStore])
);

