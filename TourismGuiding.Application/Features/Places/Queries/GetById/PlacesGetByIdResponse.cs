using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Entities.Services;
using TourismGuiding.Entities;

namespace TourismGuiding.Application.Features.Places.Queries.GetById
{
    public class PlacesGetByIdResponse
    {
        public int PlaceId { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }

        public int? EvaluationByStars { get; set; }

        public string? PositionLink { get; set; }
        public string? Description { get; set; }

        // Tourism
        public string TourismId { get; set; }
    }
}
