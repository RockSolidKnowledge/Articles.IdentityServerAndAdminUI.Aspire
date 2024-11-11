using System.Collections.Generic;
using System.Threading.Tasks;
using Articles.IdentityServerAndAdminUI.Aspire.IdentityServer.Models;

namespace Articles.IdentityServerAndAdminUI.Aspire.IdentityServer.Services;

public interface IExternalProviderService
{
    Task<IEnumerable<ExternalProvider>> GetAll();
    Task<ExternalProvider> GetScheme(string scheme);
}