using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;

namespace TourismGuiding.Application.Features.Places.Commends.Delete
{
    public class PlacesDeleteRequest :IRequest<ResponseGeneral>
    {
        public int PlaceId { get; set; }   
    }
}
