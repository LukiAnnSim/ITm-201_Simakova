CREATE TABLE [dbo].[Employees] (
    [IdEmployee] INT           NOT NULL,
    [Name]       NVARCHAR (50) NOT NULL,
    [Position]   NVARCHAR (50) NOT NULL,
    [Phone]      NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([IdEmployee] ASC)
);

