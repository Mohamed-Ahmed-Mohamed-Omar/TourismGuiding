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

namespace TourismGuiding.Application.Features.ImagesPlaces.Commends.Add
{
    public class ImagesPlacesAddHandler : IRequestHandler<ImagesPlacesAddCommend, ResponseGeneral>
    {
        private readonly IBaseRepositories<ImagesOfPlace> rep;
        private readonly IMapper mapper;


        public ImagesPlacesAddHandler(IBaseRepositories<ImagesOfPlace> rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }
        public async Task<ResponseGeneral> Handle(ImagesPlacesAddCommend request, CancellationToken cancellationToken)
        {
            var _map = mapper.Map<ImagesOfPlace>(request);

            var response = await rep.AddAsync(_map);

            return response;
        }
    }
}
