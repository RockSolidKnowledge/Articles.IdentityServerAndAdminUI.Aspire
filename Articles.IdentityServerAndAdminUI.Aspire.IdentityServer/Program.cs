using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

namespace Articles.IdentityServerAndAdminUI.Aspire.IdentityServer;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.AddServiceDefaults();
        var startup = new Startup(builder.Environment);
        startup.ConfigureServices(builder.Services);
        var app = builder.Build();
        app.MapDefaultEndpoints();
        startup.Configure(app);
        app.Run();
    }
}
