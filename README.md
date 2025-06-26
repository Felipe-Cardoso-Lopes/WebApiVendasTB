# 🚀 WebApiVendasTB: Uma Solução Robusta para Gerenciamento de Vendas

## 📝 Descrição

O `WebApiVendasTB` é uma API RESTful desenvolvida com **ASP.NET Core 8.0**, projetada para gerenciar operações essenciais de um sistema de vendas. Este projeto foca na criação de um backend eficiente e escalável para manipulação de dados de funcionários. Com uma arquitetura clara e o uso de tecnologias modernas, o `WebApiVendasTB` oferece um ponto de partida sólido para aplicações que necessitam de um sistema de vendas modular e de fácil integração.

## ✨ Funcionalidades

As principais funcionalidades oferecidas por esta API incluem:

* **Gerenciamento de Funcionários:**
    * ➕ Adicionar novos funcionários
    * ✏️ Alterar dados de funcionários existentes
    * ❌ Excluir registros de funcionários
    * 🔍 Pesquisar funcionários por ID
    * 🔎 Pesquisar funcionários por nome
    * 📋 Listar todos os funcionários registrados
* **Gerenciamento de Clientes**
* **Gerenciamento de Produtos**
* **Gerenciamento de Pedidos**
* **Gerenciamento de Itens de Venda**

## 🏗️ Arquitetura

O `WebApiVendasTB` segue uma arquitetura baseada em API RESTful, utilizando o padrão Model-View-Controller (MVC) para as requisições HTTP. É uma aplicação ASP.NET Core que separa claramente as responsabilidades:

* **Controllers:** Responsáveis por receber as requisições HTTP, como `FuncionarioController` e `WeatherForecastController`, e orquestrar as respostas, servindo como a camada de interface da API.
* **Dominio (Domain):** Contém as classes de modelo que representam as entidades de negócio do sistema, como `Funcionario`, `Cliente`, `Produto`, `Pedido`, e `ItemVenda`. Esta camada define a estrutura dos dados e a lógica de negócios central.
* **Configurações:** Arquivos como `appsettings.json` e `launchSettings.json` gerenciam as configurações da aplicação e do ambiente de execução.

## 📊 Entidades

As principais entidades do domínio do projeto são:

* **`Funcionario`**: Representa um funcionário no sistema, com as seguintes características:
    * `Id` (Int32)
    * `Nome` (string)
    * `Cpf` (string)
    * `Email` (string)
    * `Cargo` (string)
    * `Salario` (double)
    * `DataAdmissao` (DateTime)
* **`Cliente`**: Entidade para clientes do sistema.
* **`ItemVenda`**: Entidade para detalhar os itens dentro de um pedido.
* **`Pedido`**: Entidade para registrar os pedidos de venda.
* **`Produto`**: Entidade para produtos disponíveis.

## 💻 Tecnologias Utilizadas

* **Linguagem de Programação:** C#
* **Framework Web:** ASP.NET Core 8.0
* **Documentação de API:** Swagger/OpenAPI (integrado via Swashbuckle.AspNetCore)
* **Gerenciamento de Pacotes:** NuGet

## 🚀 Como Configurar e Executar o Projeto

Siga os passos abaixo para configurar e executar o `WebApiVendasTB` em sua máquina local:

### Pré-requisitos

Certifique-se de ter o seguinte software instalado em seu ambiente:

* [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) ou superior.

### Configuração

1.  **Clone o Repositório:**
    Abra seu terminal ou Git Bash e execute o seguinte comando para clonar o repositório. Certifique-se de navegar até o diretório correto do projeto após clonar:
    ```bash
    git clone <URL_DO_SEU_REPOSITORIO>
    cd WebApiVendasTB
    ```
    (Substitua `<URL_DO_SEU_REPOSITORIO>` pela URL real do seu repositório GitHub)

   
2.  **Restaure as Dependências:**
    Navegue até o diretório raiz do projeto (`WebApiVendasTB`) onde o arquivo `.csproj` está localizado e execute:
    ```bash
    dotnet restore
    ```

### Execução

1.  **Execute a Aplicação:**
    No mesmo diretório, execute o comando:
    ```bash
    dotnet run
    ```
    
2.  **Acesse a API e a Documentação do Swagger:**
    Após a execução, a API estará disponível nos seguintes endereços (configurados em `Properties/launchSettings.json`):
    * HTTP: `http://localhost:5091`
    * HTTPS: `https://localhost:7156`

    Você pode acessar a documentação interativa do Swagger UI para testar os endpoints da API através de um navegador, geralmente em:
    * `http://localhost:5091/swagger`
    * `https://localhost:7156/swagger`
