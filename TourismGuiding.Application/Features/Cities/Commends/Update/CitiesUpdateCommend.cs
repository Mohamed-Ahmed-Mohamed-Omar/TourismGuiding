using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;

namespace TourismGuiding.Application.Features.Cities.Commends.Update
{
    public class CitiesUpdateCommend : CitiesUpdateRequest , IRequest<ResponseGeneral>
    {
        public int CityId { get; set; }

    }
}
