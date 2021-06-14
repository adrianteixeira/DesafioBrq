CREATE TABLE [dbo].[Midia] (
    [Id]           INT              IDENTITY (1, 1) NOT NULL,
    [FilmeId]      INT              NOT NULL,
    [CodigoBarras] UNIQUEIDENTIFIER NOT NULL,
    [Tipo]         VARCHAR (20)     NOT NULL,
    [Disponivel]   BIT              NOT NULL,
    CONSTRAINT [PK_Midia] PRIMARY KEY CLUSTERED ([Id] ASC)
);




GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Midia]
    ON [dbo].[Midia]([Id] ASC);

