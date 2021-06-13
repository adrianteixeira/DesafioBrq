CREATE TABLE [dbo].[Cliente] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Nome]           VARCHAR (100) NOT NULL,
    [DataNascimento] DATETIME      NOT NULL,
    [Cpf]            VARCHAR (11)  NOT NULL,
    [Email]          VARCHAR (30)  NOT NULL,
    [Telefone]       VARCHAR (13)  NOT NULL,
    CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [IX_Cliente_1] UNIQUE NONCLUSTERED ([Cpf] ASC)
);



