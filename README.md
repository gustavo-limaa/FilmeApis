# Filmes API 🎥

![.NET Version](https://img.shields.io/badge/.NET-8.0-purple)
![License](https://img.shields.io/badge/license-MIT-green)
![Status](https://img.shields.io/badge/status-em%20desenvolvimento-orange)

> API desenvolvida para o gerenciamento de catálogos de filmes, aplicando conceitos de DTOs, AutoMapper e Entity Framework.

# 🎬 Filmes API

Esta é uma API robusta desenvolvida em **ASP.NET Core** para o gerenciamento de um catálogo de filmes. O projeto utiliza as melhores práticas de desenvolvimento, incluindo a separação de responsabilidades com DTOs e mapeamento de objetos.

## 🚀 Tecnologias Utilizadas

* **C# / .NET**
* **Entity Framework Core** (ORM para persistência de dados)
* **AutoMapper** (Para conversão entre Modelos e DTOs)
* **LINQ** (Para consultas de dados)

## 📁 Estrutura do Projeto

A organização das pastas segue o padrão MVC/WebAPI:

* **Controllers**: Contém os endpoints da API (ex: `FilmeController`).
* **Data**: Contexto do banco de dados (`FilmeContext`) e Data Transfer Objects (**DTOs**).
* **Models**: Representação das entidades que são salvas no banco de dados.
* **Migrations**: Histórico de versões do banco de dados.
* **Profiles**: Configurações de mapeamento do AutoMapper.
* **Pages**: (Opcional) Interface ou páginas de suporte integradas.

## 🛠️ Como Executar

1. **Clonar o repositório:**
```bash
git clone https://github.com/seu-usuario/seu-repositorio.git

```


2. **Atualizar o Banco de Dados:**
Certifique-se de que a connection string no `appsettings.json` está correta e execute:
```bash
dotnet ef database update

```


3. **Rodar a aplicação:**
```bash
dotnet run

```



## 🔌 Endpoints Principais

| Método | Endpoint | Descrição |
| --- | --- | --- |
| **POST** | `/Filme` | Cadastra um novo filme. |
| **GET** | `/Filme` | Lista filmes (com suporte a paginação via `PageResult`). |
| **PUT/PATCH** | `/Filme/{id}` | Atualiza os dados de um filme. |
| **DELETE** | `/Filme/{id}` | Remove um filme do catálogo. |

---

### 📝 Notas Adicionais

O projeto já conta com uma migration inicial (`CriandoTabelaDeFilme`) pronta para ser aplicada. O uso de DTOs (`Create`, `Read`, `Update`) garante que a camada de apresentação não exponha diretamente o modelo do banco de dados.

---
