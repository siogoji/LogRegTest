using LogRegTest.Models;
using LogRegTest.ViewModels;

namespace LogRegTest.Repositories
{
    public interface IUserAuthenticationService
    {
        Task<Status> LoginAsync(LoginViewModel model);
        Task<Status> RegistrationAsync(RegisterViewModel model);
        Task LogoutAsync();
    }
}
