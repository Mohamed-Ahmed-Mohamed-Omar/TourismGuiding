using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Application.Features.Places.Queries.GetAll
{
    public class PlacesGetAllByCityIdResponse
    {
        public int PlaceId { get; set; }
        public string Name { get; set; }

        public int? EvaluationByStars { get; set; }
       
    }
}
