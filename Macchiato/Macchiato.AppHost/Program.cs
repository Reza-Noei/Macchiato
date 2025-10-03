var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Macchiato_Server>("macchiato-server");

builder.AddNpmApp("macchiato-client", "../Presentation/Macchiato.Dashboard")
       .WithWorkingDirectory("../Presentation/Macchiato.Dashboard");

builder.Build().Run();
