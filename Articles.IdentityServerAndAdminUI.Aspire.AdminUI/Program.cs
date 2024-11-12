using IdentityExpress.Manager.BusinessLogic.Configuration;
using IdentityExpress.Manager.UI.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Configuration["IdentityConnectionString"] = Environment.GetEnvironmentVariable("ConnectionStrings__IdentityExpressDb");
builder.Configuration["IdentityServerConnectionString"] = Environment.GetEnvironmentVariable("ConnectionStrings__IdentityExpressDb");

var env = builder.Environment;

builder.Configuration
            .AddJsonFile("appsettings.json", optional: true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
            .AddEnvironmentVariables();

builder.Services.AddAdminUI(options =>
{
    options.IdentityType = IdentityType.DefaultIdentity;
    options.MigrationOptions = MigrationOptions.All;
});

var app = builder.Build();

app.MapDefaultEndpoints();

app.UseAdminUI();

app.Run();