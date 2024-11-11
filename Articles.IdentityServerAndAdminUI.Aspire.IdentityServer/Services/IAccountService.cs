using System.Threading.Tasks;
using Articles.IdentityServerAndAdminUI.Aspire.IdentityServer.Models;

namespace Articles.IdentityServerAndAdminUI.Aspire.IdentityServer.Services;

public interface IAccountService
{
    Task<LoginViewModel> BuildLoginViewModelAsync(string returnUrl);
    LoginViewModel BuildLinkLoginViewModel(string returnUrl);
    Task<LoginViewModel> BuildLoginViewModelAsync(LoginInputModel model);
    Task<LogoutViewModel> BuildLogoutViewModelAsync(string logoutId);
    Task<LoggedOutViewModel> BuildLoggedOutViewModelAsync(string logoutId);
    RegisterViewModel BuildRegisterViewModel();
    RegisterViewModel BuildRegisterViewModel(RegisterInputModel model, bool success);
}