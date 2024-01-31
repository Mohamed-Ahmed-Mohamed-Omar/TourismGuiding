using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.Places.Queries.GetAll;

namespace TourismGuiding.Application.Features.Places.Queries.GetAllByCityId
{
    public class PlacesGetAllByCityIdRequest : IRequest<IEnumerable<PlacesGetAllByCityIdResponse>>
    {
        public int CityId { get; set; }
    }
}
