using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Application.Features.Cities.Commends.Update
{
    public class CitiesUpdateRequest
    {
        public string CityName { get; set; }

        public string? Description { get; set; }

        public string? PositionLink { get; set; }
    }
}
