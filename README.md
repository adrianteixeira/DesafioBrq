# Foobar

Desafio Brq desenvolvido em .Net Core - WebApi

## Instalação

Para inicializar a aplicação, altere no appsettings.json a chave "default" uma conexão de banco local, após isso, execute o projeto Localize.Database para gerar as estruturas necessária.

```bash
"ConnectionStrings": {
    "Default": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Localize;Integrated Security=True;Connect Timeout=30"
  }
```

## Rotas

```python
POST Filmes/Filme - Registrar um filme
POST Locadores/Locador - Registrar um locador
POST Clientes/Cliente - Registrar um Cliente
POST Locacoes/Alugar - Alugar a mídia disponivel de filme
PATCH Locacoes/Devolver/{codigoBarrasMidia} - Devolver a mídia alugada de um filme

```
