CREATE TABLE [dbo].[Filme] (
    [Id]              INT           NOT NULL,
    [Nome]            VARCHAR (50)  NOT NULL,
    [Categoria]       VARCHAR (20)  NOT NULL,
    [Descricao]       VARCHAR (150) NULL,
    [Disponibilidade] BIT           NOT NULL,
    CONSTRAINT [PK_Filme] PRIMARY KEY CLUSTERED ([Id] ASC)
);

