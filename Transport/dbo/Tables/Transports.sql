CREATE TABLE [dbo].[Transports] (
    [IdTransport] INT           NOT NULL,
    [TrackNumber] INT           NOT NULL,
    [StateNumber] NVARCHAR (10) NOT NULL,
    [Owner]       NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Transports] PRIMARY KEY CLUSTERED ([IdTransport] ASC)
);

