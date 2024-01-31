using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities.NewFolder;
using TourismGuiding.Entities.Services;

namespace TourismGuiding.Application.Features.ImagesCities.Commends.Add
{
    public class ImagesCitiesAddHandler : IRequestHandler<ImagesCitiesAddCommend, ResponseGeneral>
    {
        private readonly IBaseRepositories<ImagesOfCity> rep;
        private readonly IMapper mapper;


        public ImagesCitiesAddHandler(IBaseRepositories<ImagesOfCity> rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }
        public async Task<ResponseGeneral> Handle(ImagesCitiesAddCommend request, CancellationToken cancellationToken)
        {
            var _map = mapper.Map<ImagesOfCity>(request);

            var response = await rep.AddAsync(_map);

            return response;    
        }
    }
}
