using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Entities.Images;

namespace TourismGuiding.Application.Features.ImagesCities.Queries.GetAll
{
    public class ImagesCitiesGetAllRequest : IRequest<IEnumerable<ImageUrlOfCOrP>>
    {
        public int CityId { get; set; }
    }
}
