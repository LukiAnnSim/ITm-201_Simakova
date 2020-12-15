CREATE TABLE [dbo].[Products] (
    [IdProduct] INT           NOT NULL,
    [Name]      NVARCHAR (50) NOT NULL,
    [IssueYear] INT           NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([IdProduct] ASC)
);

