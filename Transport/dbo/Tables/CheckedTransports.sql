CREATE TABLE [dbo].[CheckedTransports] (
    [IdCheck]     INT NOT NULL,
    [Quantity]    INT NOT NULL,
    [IdDate]      INT NOT NULL,
    [IdEmloyee]   INT NOT NULL,
    [IdTransport] INT NOT NULL,
    CONSTRAINT [PK_CheckedTransports] PRIMARY KEY CLUSTERED ([IdCheck] ASC),
    CONSTRAINT [FK_CheckedTransports_Dates] FOREIGN KEY ([IdDate]) REFERENCES [dbo].[Dates] ([IdDate]),
    CONSTRAINT [FK_CheckedTransports_Employees] FOREIGN KEY ([IdEmloyee]) REFERENCES [dbo].[Employees] ([IdEmployee]),
    CONSTRAINT [FK_CheckedTransports_Transports] FOREIGN KEY ([IdTransport]) REFERENCES [dbo].[Transports] ([IdTransport])
);

