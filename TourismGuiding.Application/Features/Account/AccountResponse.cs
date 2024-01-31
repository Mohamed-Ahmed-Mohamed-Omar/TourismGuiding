using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TourismGuiding.Application.Features.Account
{
    public class AccountResponse
    {
        public string? Message { get; set; }
        public bool IsAuthenticed { get; set; }

        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? Token { get; set; }
    }
}
