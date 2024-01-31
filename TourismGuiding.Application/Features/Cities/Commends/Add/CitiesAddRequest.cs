using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;

namespace TourismGuiding.Application.Features.Cities.Commends.Add
{
    public class CitiesAddRequest : IRequest<ResponseGeneral>
    {
        public string CityName { get; set; }

        public string? Description { get; set; }

        public string? PositionLink { get; set; }
    }
}
