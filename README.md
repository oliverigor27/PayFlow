# PayFlow - Serviço de Pagamento

![.NET Core](https://img.shields.io/badge/.NET-9-blue)
![License](https://img.shields.io/badge/license-Apache%202.0-blue)
![Build Status](https://img.shields.io/badge/build-passing-brightgreen)

**PayFlow** é uma solução de pagamento simples e eficiente, desenvolvida para facilitar a maneira como os usuários realizam suas compras na internet. O sistema utiliza C#, ASP.NET 9, PostgreSQL, JWT e a API do Mercado Pago para garantir uma integração rápida e segura no processo de pagamento.

## Tecnologias Utilizadas

- **C#**: Linguagem de programação principal para o desenvolvimento backend.
- **ASP.NET 9**: Framework utilizado para construção da API.
- **PostgreSQL**: Banco de dados relacional utilizado para persistência de dados.
- **JWT (JSON Web Tokens)**: Utilizado para autenticação e autorização de usuários.
- **Mercado Pago API**: Integração com o Mercado Pago para processar os pagamentos de forma segura e eficaz.

## Funcionalidades

- **Autenticação de Usuário**: Realiza o login utilizando JWT para garantir segurança e uma experiência de usuário fluida.
- **Cadastro e Gerenciamento de Pagamentos**: O sistema permite o registro de transações de pagamento com diversos métodos, utilizando a API do Mercado Pago.
- **Controle de Transações**: O sistema registra e consulta todas as transações realizadas, permitindo ao administrador o gerenciamento completo dos pagamentos.
- **Integração com Mercado Pago**: O PayFlow oferece uma integração robusta com o Mercado Pago, permitindo que os pagamentos sejam processados diretamente pela plataforma.

## Como Executar o Projeto

### Pré-requisitos

Antes de executar o projeto, certifique-se de ter os seguintes pré-requisitos instalados:

- [.NET 9](https://dotnet.microsoft.com/download/dotnet)
- [PostgreSQL](https://www.postgresql.org/download/)
- [Mercado Pago Account](https://www.mercadopago.com.br/)
- [Postman](https://www.postman.com/) (opcional para testar as APIs)

### Passos para Execução

1. Clone este repositório:

   ```bash
   git clone https://github.com/seu-usuario/payflow.git
   cd payflow
   ```

2. Configure o banco de dados PostgreSQL:
   - Crie um banco de dados no PostgreSQL e configure as credenciais no arquivo `appsettings.json`:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Port=5432;Username=seu_usuario;Password=sua_senha;Database=payflow_db"
     }
   }
   ```

3. Instale as dependências:

   ```bash
   dotnet restore
   ```

4. Aplique as migrações do banco de dados:

   ```bash
   dotnet ef database update
   ```

5. Crie o arquivo `appsettings.json` para configurar as credenciais do Mercado Pago e JWT:

   ```json
   {
     "MercadoPago": {
       "AccessToken": "SEU_ACCESS_TOKEN"
     },
     "JwtSettings": {
       "SecretKey": "SUA_CHAVE_SECRETA"
     }
   }
   ```

6. Execute a aplicação:

   ```bash
   dotnet run
   ```

7. O servidor estará rodando em `http://localhost:5000` e você pode começar a realizar as requisições de API.


## Licença

Este projeto está licenciado sob a licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.
