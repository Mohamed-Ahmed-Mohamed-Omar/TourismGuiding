using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Application.Features.Places.Queries.GetAllByTourismId
{
    public class PlacesGetAllByTourismIdRequest : IRequest<IEnumerable<PlacesGetAllByTourismIdResponse>>
    {
         public int TourismId { get; set; }
    }
}
