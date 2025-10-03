var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Macchiato_Server>("macchiato-server");

builder.AddNpmApp("macchiato-dashboard", "../Presentation/Macchiato.Dashboard")
       .WithWorkingDirectory("../Presentation/Macchiato.Dashboard")
       .WithUrl("https://127.0.0.1:4200");

builder.Build().Run();
