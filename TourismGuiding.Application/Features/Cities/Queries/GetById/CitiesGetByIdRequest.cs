using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Application.Features.Cities.Queries.GetById
{
    public class CitiesGetByIdRequest : IRequest<CitiesGetByIdResponse>
    {
        public int CityId { get; set; }
    }
}
