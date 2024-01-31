using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.Cities.Commends.Add;
using TourismGuiding.Application.Features.ResponseGeneration;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities;

namespace TourismGuiding.Application.Features.Places.Commends.Add
{
    public class PlacesAddHandler : IRequestHandler<PlacesAddCommend, ResponseGeneral>
    {
        private readonly IBaseRepositories<Place> rep;
        private readonly IMapper mapper;

        public PlacesAddHandler(IBaseRepositories<Place> rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }
      
        public async Task<ResponseGeneral> Handle(PlacesAddCommend request, CancellationToken cancellationToken)
        {
            var _mapper = mapper.Map<Place>(request);

            var response = await rep.AddAsync(_mapper);

            return response;
        }
    }
}
