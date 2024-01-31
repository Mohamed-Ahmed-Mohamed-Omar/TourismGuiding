using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTeacher.Application.Interfaces;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities.Images;
using TourismGuiding.Entities.NewFolder;

namespace TourismGuiding.Application.Features.ImagesCities.Queries.GetAll
{
    public class ImagesCitiesGetAllHandler : IRequestHandler<ImagesCitiesGetAllRequest, IEnumerable<ImageUrlOfCOrP>>
    {
   
        private readonly IHelper helper;
        private readonly IMapper mapper;


        public ImagesCitiesGetAllHandler(IHelper helper, IMapper mapper)
        {
       
            this.helper = helper;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<ImageUrlOfCOrP>> Handle(ImagesCitiesGetAllRequest request, CancellationToken cancellationToken)
        {

            var response = await helper.GetImagesOfCity(request.CityId);

            return response;

        }
    }
}
