using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Entities.Account
{
    public class ApplicationUser : IdentityUser
    {
       public string? FullName { get; set; }

    }
}
