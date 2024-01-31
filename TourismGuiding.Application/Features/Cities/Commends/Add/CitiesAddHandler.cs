using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities;

namespace TourismGuiding.Application.Features.Cities.Commends.Add
{
    public class CitiesAddHandler : IRequestHandler<CitiesAddRequest, ResponseGeneral>
    {
        private readonly IBaseRepositories<City> rep;
        private readonly IMapper mapper;

        public CitiesAddHandler(IBaseRepositories<City> rep,IMapper mapper)
        {
            this.rep = rep;

            this.mapper = mapper;
        }
        public async Task<ResponseGeneral> Handle(CitiesAddRequest request, CancellationToken cancellationToken)
        {
            var _mapper = mapper.Map<City>(request);

            var response = await rep.AddAsync(_mapper);

            return response;
        }
    }
}
