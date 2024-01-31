using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;

namespace TourismGuiding.Application.Features.ImagesPlaces.Commends.Delete
{
    public class ImagesPlacesDeleteRequest : IRequest<ResponseGeneral>
    {
        public int ImageId { get; set; }
    }
}
