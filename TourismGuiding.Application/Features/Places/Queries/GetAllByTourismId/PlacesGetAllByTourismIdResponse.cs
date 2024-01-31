using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Application.Features.Places.Queries.GetAllByTourismId
{
    public class PlacesGetAllByTourismIdResponse
    {
        public int PlaceId { get; set; }
        public string Name { get; set; }

        public int? EvaluationByStars { get; set; }
       
    }
}
