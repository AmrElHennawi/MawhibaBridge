using MawhibaBridge.Application.DTOs;

namespace MawhibaBridge.Application.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<string> Login(LoginDto loginData);
        Task<string> Register(RegisterDto registerData);
    }
}
