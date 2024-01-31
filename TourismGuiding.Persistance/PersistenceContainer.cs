
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TopTeacher.Application.Interfaces;
using TopTeacher.Persistance.Repositories;
using TourismGuiding.Application.Features.Account;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities.Account;
using TourismGuiding.Persistance;
using TourismGuiding.Persistance.Helper;
using TourismGuiding.Persistance.Repositories;

namespace TourismGuiding.Persistance
{
    public static class PersistenceContainer
    {
        public static IServiceCollection AddPersistenceService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("connectionString")));

            #region JWT 
            services.Configure<JWT>(configuration.GetSection("JWT"));

           // Authorize for Bearer by Defualt without add to each controller

           services.AddAuthentication(options =>
           {
               options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
               options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
               
           })
               .AddJwtBearer(o =>
               {
                   o.RequireHttpsMetadata = false;
                   o.SaveToken = false;
                   o.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuerSigningKey = true,
                       ValidateIssuer = true,
                       ValidateAudience = true,
                       ValidateLifetime = true,
                       ValidIssuer = configuration["JWT:Issuer"],
                       ValidAudience = configuration["JWT:Audience"],
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"])),
                       ClockSkew = TimeSpan.Zero
                   };
               });
            #endregion

            // DI Identity
            services.AddIdentity<ApplicationUser, IdentityRole>(
               options =>
               {
                   // Default Password settings.
                   options.Password.RequireDigit = true;
                   options.Password.RequireLowercase = true;
                   options.Password.RequireNonAlphanumeric = true;
                   options.Password.RequireUppercase = true;
                   options.Password.RequiredLength = 6;
                   options.Password.RequiredUniqueChars = 1;
               }
               ).AddEntityFrameworkStores<ApplicationDbContext>()
               .AddDefaultUI();

         


            // DI

            services.AddScoped(typeof(IBaseRepositories<>), typeof(BaseRepositories<>));
            services.AddScoped<IHelper, HelperRepositories>();
           services.AddScoped<IAuthService, AuthService>();


            // Json
            services.AddControllers().AddJsonOptions(
                options =>
                {
                    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
                });
                
            services.AddControllers().AddNewtonsoftJson(
                options =>
                {
                  options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                });
            
            
            return services;

        }
    }
}
