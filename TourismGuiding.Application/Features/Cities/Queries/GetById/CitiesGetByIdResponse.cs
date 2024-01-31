using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TourismGuiding.Entities;
using TourismGuiding.Entities.Images;
using TourismGuiding.Entities.NewFolder;

namespace TourismGuiding.Application.Features.Cities.Queries.GetById
{
    public class CitiesGetByIdResponse
    {
        
        public string CityName { get; set; }

        public string? Description { get; set; }

        public string? PositionLink { get; set; }
   
        
    }
}
