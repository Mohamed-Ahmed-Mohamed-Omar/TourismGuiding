using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Entities.NewFolder;
using TourismGuiding.Entities.Services;

namespace TourismGuiding.Entities
{
    public class Place
    {
        public int PlaceId { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        
        public int? EvaluationByStars { get; set; }

        public string? PositionLink { get; set; }

       
        public string? Description { get; set; }

     
        public ICollection<Department>? Departments { get; set; }


        // Tourism
        public int TourismId { get; set; }
        public Tourism Tourism { get; set; }


        // City

        public int CityId { get; set; }
        public City City { get; set; }

    }
}
