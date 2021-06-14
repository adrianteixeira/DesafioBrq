CREATE TABLE [dbo].[Locador] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Nome]     VARCHAR (50) NOT NULL,
    [Cpf]      VARCHAR (13) NOT NULL,
    [Salario]  MONEY        NOT NULL,
    [Telefone] VARCHAR (13) NOT NULL,
    CONSTRAINT [PK_Locador] PRIMARY KEY CLUSTERED ([Id] ASC)
);






GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Locador]
    ON [dbo].[Locador]([Cpf] ASC);



