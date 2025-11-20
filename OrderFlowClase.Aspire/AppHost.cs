using Aspire.Hosting.Postgres;

var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder
    .AddPostgres("postgres")
    .WithPgAdmin(pgAdmin => pgAdmin.WithHostPort(5050));
    //.WithDataVolume("postgres")
    //.WithLifetime(ContainerLifetime.Persistent);

var postgresdb = postgres.AddDatabase("identitydb");

builder.AddProject<Projects.OrderFlowClase_API_Identity>("orderflowclase-api-identity")
    .WaitFor(postgresdb)
    .WithReference(postgres);

builder.Build().Run();
