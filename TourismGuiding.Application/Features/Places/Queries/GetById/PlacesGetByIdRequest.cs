using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Application.Features.Places.Queries.GetById
{
    public class PlacesGetByIdRequest : IRequest<PlacesGetByIdResponse>
    {
        public int PlaceId { get; set; }


    }
}
