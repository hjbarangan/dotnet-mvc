HEADS UP SA TRAINING HAHA


To create a .NET MVC application - ```dotnet new mvc -o <application-name>```

Redirect into vscode - ```code -r <application-name>```


Hot Reload - ```dotnet watch```

TO install 

dotnet tool install --global dotnet-ef --version 7.0.0 --add-source https://api.nuget.org/v3/index.json
dotnet tool install --global  dotnet-aspnet-codegenerator --version 7.0.0 --add-source https://api.nuget.org/v3/index.json

dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.0 --source https://api.nuget.org/v3/index.json
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 7.0.0 --source https://api.nuget.org/v3/index.json
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 7.0.0 --source https://api.nuget.org/v3/index.json
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.0 --source https://api.nuget.org/v3/index.json
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.0 --source https://api.nuget.org/v3/index.json

SCAFFOLD 
dotnet aspnet-codegenerator controller -name MoviesController -m Movie -dc MvcMovie.Data.MvcMovieContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries


dotnet ef migrations add InitialCreate
dotnet ef database update


DOCS LINK - https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-8.0&tabs=visual-studio

