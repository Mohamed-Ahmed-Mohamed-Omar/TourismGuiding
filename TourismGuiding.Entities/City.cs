using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Entities.NewFolder;

namespace TourismGuiding.Entities
{
    public class City
    {
        public int CityId { get; set; }

        public string CityName { get; set; }


        public string? Description { get; set; }

        public string? PositionLink { get; set; }

        public ICollection<Place>? Places { get; set; }

    } 
}