using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Entities.Images;

namespace TourismGuiding.Application.Features.ImagesPlaces.Queries.GetAll
{
    public class ImagesPlacesGetAllRequest : IRequest<IEnumerable<ImageUrlOfCOrP>>
    {
        public int PlaceId { get; set; }
    }
}
