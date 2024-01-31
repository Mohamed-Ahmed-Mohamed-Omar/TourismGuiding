using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

using System;
using System.Collections.Generic;

using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Interfaces;

namespace TourismGuiding.Application.Features.Account.Loginn
{
    
    public class AccountLoginHandler : IRequestHandler<AccountLoginRequest, AccountResponse>
    {
        private readonly IAuthService auth;

        public AccountLoginHandler(IAuthService auth )
        {
            this.auth = auth;
        }

        public async Task<AccountResponse> Handle(AccountLoginRequest request, CancellationToken cancellationToken)
        {
            var response = await auth.GetTokenAsync(request);

            return response;
        }
    }
}
