using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Entities.Services;

namespace TourismGuiding.Entities.NewFolder
{
    
    public class ImagesOfCity
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        // Ids
        public int CityId { get; set; }
       
    }
}
