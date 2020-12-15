CREATE TABLE [dbo].[TransportCollapse] (
    [IdCollapse]  INT NOT NULL,
    [Quantity]    INT NOT NULL,
    [IdDate]      INT NOT NULL,
    [IdReason]    INT NOT NULL,
    [IdTransport] INT NOT NULL,
    CONSTRAINT [PK_TransportCollapse] PRIMARY KEY CLUSTERED ([IdCollapse] ASC),
    CONSTRAINT [FK_TransportCollapse_CollapseReasons] FOREIGN KEY ([IdReason]) REFERENCES [dbo].[CollapseReasons] ([IdReason]),
    CONSTRAINT [FK_TransportCollapse_Dates] FOREIGN KEY ([IdDate]) REFERENCES [dbo].[Dates] ([IdDate]),
    CONSTRAINT [FK_TransportCollapse_Transports] FOREIGN KEY ([IdTransport]) REFERENCES [dbo].[Transports] ([IdTransport])
);

