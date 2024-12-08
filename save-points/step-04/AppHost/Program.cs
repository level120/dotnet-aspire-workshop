using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var mysql = builder.AddMySql("mysql").AddDatabase("workshopdb");

// builder.AddProject<BicycleSharingSystem_WebApi>("webapi");
builder.AddProject<BicycleSharingSystem_WebApi>("webapi")
       .WithReference(mysql);
builder.Build().Run();
