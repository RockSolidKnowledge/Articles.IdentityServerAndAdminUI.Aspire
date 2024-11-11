var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Articles_IdentityServerAndAdminUI_Aspire_AdminUI>("articles-identityserverandadminui-aspire-adminui");

builder.Build().Run();
