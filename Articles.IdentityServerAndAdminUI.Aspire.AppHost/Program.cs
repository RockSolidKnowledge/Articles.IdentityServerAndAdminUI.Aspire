var builder = DistributedApplication.CreateBuilder(args);
var sqlServer = builder.AddSqlServer("TestServer")
    .WithHealthCheck()
    .WithDataVolume("MyDataVolume");
var identityExpressDb = sqlServer.AddDatabase("IdentityExpressDb");
identityExpressDb.WaitFor(sqlServer);

var adminui = builder.AddProject<Projects.Articles_IdentityServerAndAdminUI_Aspire_AdminUI>("articles-identityserverandadminui-aspire-adminui")
    .WithReference(identityExpressDb)
    .WaitFor(identityExpressDb);

builder.AddProject<Projects.Articles_IdentityServerAndAdminUI_Aspire_IdentityServer>("articles-identityserverandadminui-aspire-identityserver")
    .WithReference(identityExpressDb)
    .WaitFor(adminui)
    .WaitFor(identityExpressDb);

builder.Build().Run();