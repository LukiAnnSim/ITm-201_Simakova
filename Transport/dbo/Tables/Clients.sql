CREATE TABLE [dbo].[Clients] (
    [IdClient] INT           NOT NULL,
    [Name]     NVARCHAR (50) NOT NULL,
    [E-mail]   NVARCHAR (50) NOT NULL,
    [Phone]    NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED ([IdClient] ASC)
);

