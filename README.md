# Investment.Api

## Introdução

Api Rest para consulta das ações na bolsa de valores

### Rotas

- `GET /`: Retorna usuário logado.
- `POST /`: Utilizado para cadastrar o usuário na base.

- Observação : Informar no Header do método POST a API_KEY.
  Essa chave pode ser modificada no arquivo appsettings.json.
  O método GET utiliza token Jwt

## Como Utilizar

- Após a inicialização do projeto será aberto a documentação da Api na rota.
- É necessário estar autenticado com o firebase.Você pode conseguir um token válido
  utilizando o app disponível no repositório : https://github.com/bessajonathan/Investment.App
  basta entrar com sua conta do google.

## Ferramentas utilizadas

-- AutoMapper
-- Firebase
-- MSSQL
-- EntityFramework
-- Mediator
-- Nunit
-- Hangfire

## Sdk

-- .Net 5

## Conceitos utilizados

-- Clean Architecture
-- Solid
-- Repository Pattern
-- Injeção de dependência

## Subir container docker

-- Vá até a pasta Investment.Api e rode o comando "docker build -t investment.api ."
