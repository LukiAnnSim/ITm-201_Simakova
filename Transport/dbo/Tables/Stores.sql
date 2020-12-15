CREATE TABLE [dbo].[Stores] (
    [IdStore] INT           NOT NULL,
    [Name]    NVARCHAR (50) NOT NULL,
    [Address] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Stores] PRIMARY KEY CLUSTERED ([IdStore] ASC)
);

