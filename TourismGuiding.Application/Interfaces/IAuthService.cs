using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.Account.Loginn;
using TourismGuiding.Application.Features.Account;

namespace TourismGuiding.Application.Interfaces
{
    public interface IAuthService
    {
        Task<AccountResponse> GetTokenAsync(AccountLoginRequest login);
    }
}
