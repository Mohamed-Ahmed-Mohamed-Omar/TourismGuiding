using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.Account;
using TourismGuiding.Application.Features.Account.Loginn;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities.Account;
using TourismGuiding.Persistance.Helper;

namespace TourismGuiding.Persistance.Repositories
{
    public class AuthService : IAuthService
    {
        public readonly UserManager<ApplicationUser> userManager;
        public readonly RoleManager<IdentityRole> roleManager;
        public readonly JWT jwt;
        public AuthService(IOptions<JWT> jwt, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.jwt = jwt.Value;
        }
        public async Task<AccountResponse> GetTokenAsync(AccountLoginRequest login)
        {
            AccountResponse model = new AccountResponse();

            var user = await userManager.FindByEmailAsync(login.Email);

            if (user is null || !await userManager.CheckPasswordAsync(user, login.Password))
            {
                model.Message = "Email Or Password is incorect!";
                return model;
            }
            var jwtSecurityToken = await CreateJwtToken(user);
           
            model.IsAuthenticed = true;
            model.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            model.Email = user.Email;
            model.Username = user.UserName;


            return model;
        }

        private async Task<JwtSecurityToken> CreateJwtToken(ApplicationUser user)
        {
            var userClaims = await userManager.GetClaimsAsync(user);
            var roles = await userManager.GetRolesAsync(user);
            var roleClaims = new List<Claim>();

            foreach (var role in roles)
                roleClaims.Add(new Claim("roles", role));

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id)
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: jwt.Issuer,
                audience: jwt.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(jwt.DurationInMinutes),
                signingCredentials: signingCredentials);

            return jwtSecurityToken;
        }
    }
}
