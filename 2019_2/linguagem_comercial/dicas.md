# CSharp

1. prop (criar variavel comm get e set)
2. ctrl .
3. dotnet new console -o nome_do_projeto
4. dotnet new mvc -o nome_do_projeto
5. Desenvolvimento na maquina local usando https (dotnet dev-certs https --trust)

dotnet tool install --global dotnet-aspnet-codegenerator
dotnet aspnet-codegenerator razorpage -m Movie -dc RazorPagesMovieContext -udl -outDir Pages\Movies --referenceScriptLibraries

-   O processo de scaffold cria e atualiza os arquivos a seguir:

1.  -   Arquivos criados
        1.1 - Pages/Movies: Criar, Excluir, Detalhes, Editar e Índice.
        1.2 - Data/RazorPagesMovieContext.cs

2.  -   Arquivo atualizado
        2.1 - Startup.cs

[dotnet aspnet-codegenerator](https://docs.microsoft.com/pt-br/aspnet/core/fundamentals/tools/dotnet-aspnet-codegenerator?view=aspnetcore-2.2)
Parâmetro ------------------------ DESCRIÇÃO
-m ------------------------------- O nome do modelo.
-dc ------------------------------ A classe DbContext a ser usada.
-udl ----------------------------- Use o layout padrão.
-outDir -------------------------- O caminho da pasta de saída relativa para criar as exibições.
--referenceScriptLibraries ------- Adiciona \_ValidationScriptsPartial para editar e criar páginas

dotnet aspnet-codegenerator razorpage -h (help)

## Migrações [documentação](https://docs.microsoft.com/pt-br/aspnet/core/data/ef-mvc/migrations?view=aspnetcore-2.2)

1. dotnet ef migrations add InitialCreate
2. dotnet ef database update

O pacote Microsoft.VisualStudio.Web.CodeGeneration.Design é necessário para scaffolding.

dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
