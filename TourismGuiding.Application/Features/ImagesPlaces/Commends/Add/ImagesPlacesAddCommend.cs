using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;

namespace TourismGuiding.Application.Features.ImagesPlaces.Commends.Add
{
    public class ImagesPlacesAddCommend : IRequest<ResponseGeneral>
    {
        public string ImageUrl { get; set; }

  

        public int PlaceId { get; set; }
    }
}
