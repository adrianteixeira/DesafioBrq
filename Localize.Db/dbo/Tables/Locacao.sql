CREATE TABLE [dbo].[Locacao] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [MidiaId]       INT            NOT NULL,
    [ClienteId]     INT            NOT NULL,
    [LocadorId]     INT            NOT NULL,
    [DataAluguel]   DATETIME       NOT NULL,
    [DataDevolucao] DATETIME       NOT NULL,
    [Preco]         MONEY          NOT NULL,
    [Desconto]      DECIMAL (5, 2) NULL,
    CONSTRAINT [PK_Locacao] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Locacao_Cliente] FOREIGN KEY ([Id]) REFERENCES [dbo].[Cliente] ([Id]),
    CONSTRAINT [FK_Locacao_Locador] FOREIGN KEY ([LocadorId]) REFERENCES [dbo].[Locador] ([Id]),
    CONSTRAINT [FK_Locacao_Midia] FOREIGN KEY ([MidiaId]) REFERENCES [dbo].[Midia] ([Id])
);

