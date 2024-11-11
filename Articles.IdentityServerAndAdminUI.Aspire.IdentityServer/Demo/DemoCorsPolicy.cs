using System.Threading.Tasks;
using Duende.IdentityServer.Services;

namespace Articles.IdentityServerAndAdminUI.Aspire.IdentityServer.Demo
{
    /// <summary>
    /// Allows any CORS origin - DO NOT USE IN PRODUCTION
    /// </summary>
    public class DemoCorsPolicy : ICorsPolicyService
    {
        public Task<bool> IsOriginAllowedAsync(string origin)
        {
            return Task.FromResult(true);
        }
    }
}