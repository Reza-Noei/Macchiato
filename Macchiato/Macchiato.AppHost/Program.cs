var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Macchiato_Server>("macchiato-server");

//builder.AddProject<Projects.macchiato_client>("macchiato-client");

builder.AddNpmApp("macchiato-client", "../Presentation/macchiato.client")
       .WithWorkingDirectory("../Presentation/macchiato.client");

builder.Build().Run();
