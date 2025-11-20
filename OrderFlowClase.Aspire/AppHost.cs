var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.OrderFlowClase_API_Identity>("orderflowclase-api-identity");

builder.Build().Run();
