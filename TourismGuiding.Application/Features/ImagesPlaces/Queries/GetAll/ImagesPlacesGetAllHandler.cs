using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTeacher.Application.Interfaces;
using TourismGuiding.Entities.Images;

namespace TourismGuiding.Application.Features.ImagesPlaces.Queries.GetAll
{
    public class ImagesPlacesGetAllHandler : IRequestHandler<ImagesPlacesGetAllRequest,IEnumerable<ImageUrlOfCOrP>>
    {
        private readonly IHelper helper;
        private readonly IMapper mapper;


        public ImagesPlacesGetAllHandler(IHelper helper, IMapper mapper)
        {

            this.helper = helper;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ImageUrlOfCOrP>> Handle(ImagesPlacesGetAllRequest request, CancellationToken cancellationToken)
        {
            var response = await helper.GetImagesOfPlace(request.PlaceId);

            return response;
        }
    }
}
