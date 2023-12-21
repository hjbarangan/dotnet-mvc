
To create a .NET MVC application - ```dotnet new mvc -o <application-name>```
Redirect into vscode - ```code -r <application-name>```
Hot Reload - ```dotnet watch```

  

### **INSTALLATION:**

**Tools Used for Database Migrations and Scaffolding**

This tool is for Entity Framework Core. It allows you to interact with your Entity Framework Core projects from the command line.
```
dotnet tool install --global dotnet-ef --version 7.0.0 --add-source https://api.nuget.org/v3/index.json
```


```
dotnet tool install --global  dotnet-aspnet-codegenerator --version 7.0.0 --add-source https://api.nuget.org/v3/index.json

```

**Packages** - 

```
dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.0 --source https://api.nuget.org/v3/index.json

dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 7.0.0 --source https://api.nuget.org/v3/index.json

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 7.0.0 --source https://api.nuget.org/v3/index.json

dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.0 --source https://api.nuget.org/v3/index.json

dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.0 --source https://api.nuget.org/v3/index.json
```

### **SCAFFOLD**

```
dotnet aspnet-codegenerator controller -name MoviesController -m Movie -dc MvcMovie.Data.MvcMovieContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

```
  
  
### **DATABASE**

```
dotnet ef migrations add InitialCreate
```

This is used to add a new migration. When you're ready to persist changes to your data model (e.g., adding a new table or modifying an existing one), you create a migration to capture those changes. 

`InitialCreate`: This is the name you are giving to the migration. It's a meaningful name that describes the purpose of the migration. In this case, "InitialCreate" suggests that this is the first migration in your project, often created when setting up the initial database schema.

```
dotnet ef database update
```

Once the migration is generated, you typically apply it to the database using the `dotnet ef database update` command. This updates the actual database schema to match the changes described in the migration.

**DOCS LINK** 
https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-8.0&tabs=visual-studio