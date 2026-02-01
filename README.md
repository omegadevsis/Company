# Template de Solução Clean Architecture

Este é um template de solução para criar uma aplicação web baseada em Clean Architecture usando .NET.

## Instalação

Para instalar este template, execute o seguinte comando no diretório raiz deste projeto:

```bash
dotnet new install .
```

## Uso

Uma vez instalado, você pode criar uma nova solução usando:

```bash
dotnet new company-ca -n NomeDoSeuProjeto
```

## Estrutura

- **Domain**: Contém entidades, enums e lógica de domínio.
- **Application**: Contém lógica de negócios, interfaces, comandos (commands) e consultas (queries).
- **Infrastructure**: Contém acesso a dados e implementação de serviços externos.
- **Presentation**: Contém a API e o ponto de entrada da aplicação.
