# CleanArch

Projeto em **ASP.NET Core MVC** (.NET 8) que aplica **Clean Architecture**, com CRUD de **Produtos** e uso de **Entity Framework Core** e **SQL Server**.

## Estrutura da solução

| Projeto | Descrição |
|--------|------------|
| **CleanArch.Domain** | Núcleo: entidade `Product` e interface `IProductRepository`. Sem dependências de outras camadas. |
| **CleanArch.Application** | Casos de uso: `IProductService`, `ProductService`, `ProductViewModel` e mapeamentos AutoMapper (Domain ↔ ViewModel). |
| **CleanArch.Infra.Data** | Infraestrutura de dados: `ApplicationDbContext` (EF Core + Identity), `ProductRepository`, configuração da entidade e migrations. |
| **CleanArch.Infra.IoC** | Injeção de dependências: registro de DbContext, Identity, repositórios e serviços. |
| **CleanArch.MVC** | Apresentação: controllers (Home, Products), views, configuração do pipeline e do AutoMapper. |

## Tecnologias

- .NET 8
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- AutoMapper
- ASP.NET Core Identity

## Como executar

1. **Clonar/abrir o repositório** e abrir a solução `CleanArch.sln` na pasta `CleanArch`.

2. **Configurar a conexão com o banco**  
   Em `CleanArch.MVC/appsettings.json`, ajuste a connection string `DefaultConnection` para o seu SQL Server:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=SEU_SERVIDOR;Database=CleanArchDemoDB;..."
   }
   ```

3. **Aplicar as migrations** (na pasta do projeto MVC ou na raiz da solução):
   ```bash
   cd CleanArch.MVC
   dotnet ef database update --project ..\CleanArch.Infra.Data
   ```

4. **Rodar a aplicação**:
   ```bash
   cd CleanArch.MVC
   dotnet run
   ```
   Ou executar o projeto **CleanArch.MVC** como projeto de inicialização no Visual Studio.

5. Acessar no navegador (ex.: `https://localhost:5xxx` ou a URL exibida no terminal). A rota **/Products** traz o CRUD de produtos.

## Funcionalidades

- **Produtos**: listagem (Index), criação (Create), edição (Edit), detalhes (Details) e exclusão (Delete).
- **Home**: página inicial, Privacy e página de erro.
- **Identity**: estrutura de autenticação configurada (confirmação de conta habilitada).

## Observações

- O banco é criado/atualizado via migrations. A configuração `ProductConfiguration` inclui dados iniciais (seed) de exemplo para a tabela de produtos.
- A camada de apresentação depende apenas de `IProductService` e ViewModels; o domínio e a infraestrutura ficam desacoplados.
