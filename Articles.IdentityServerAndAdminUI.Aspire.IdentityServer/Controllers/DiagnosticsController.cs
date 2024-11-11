using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Articles.IdentityServerAndAdminUI.Aspire.IdentityServer.Middleware;
using Articles.IdentityServerAndAdminUI.Aspire.IdentityServer.Models;

namespace Articles.IdentityServerAndAdminUI.Aspire.IdentityServer.Controllers
{
    [Authorize]
    [SecurityHeaders]
    public class DiagnosticsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var model = new DiagnosticsViewModel(await HttpContext.AuthenticateAsync());
            return View(model);
        }
    }
}