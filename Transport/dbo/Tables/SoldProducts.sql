CREATE TABLE [dbo].[SoldProducts] (
    [IdSale]     INT NOT NULL,
    [Quantity]   INT NOT NULL,
    [IdDate]     INT NOT NULL,
    [IdProduct]  INT NOT NULL,
    [IdClient]   INT NOT NULL,
    [IdEmployee] INT NOT NULL,
    CONSTRAINT [PK_SoldProducts] PRIMARY KEY CLUSTERED ([IdSale] ASC),
    CONSTRAINT [FK_SoldProducts_Clients] FOREIGN KEY ([IdClient]) REFERENCES [dbo].[Clients] ([IdClient]),
    CONSTRAINT [FK_SoldProducts_Dates] FOREIGN KEY ([IdDate]) REFERENCES [dbo].[Dates] ([IdDate]),
    CONSTRAINT [FK_SoldProducts_Employees] FOREIGN KEY ([IdEmployee]) REFERENCES [dbo].[Employees] ([IdEmployee]),
    CONSTRAINT [FK_SoldProducts_Products] FOREIGN KEY ([IdProduct]) REFERENCES [dbo].[Products] ([IdProduct])
);

