CREATE TABLE [dbo].[Filme] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Nome]      VARCHAR (50)  NOT NULL,
    [Categoria] VARCHAR (20)  NOT NULL,
    [Descricao] VARCHAR (MAX) NULL,
    CONSTRAINT [PK_Filme] PRIMARY KEY CLUSTERED ([Id] ASC)
);





