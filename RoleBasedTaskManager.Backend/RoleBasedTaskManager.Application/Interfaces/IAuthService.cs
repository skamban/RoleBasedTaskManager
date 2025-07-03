using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoleBasedTaskManager.Application.DTO;

namespace RoleBasedTaskManager.Application.Interfaces
{
    internal interface IAuthService
    {
       Task<AuthResponse> RegisterAsync(RegisterRequest request);
        Task<AuthResponse> LoginAsync(LoginRequest request);
    }
}
