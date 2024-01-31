using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTeacher.Application.Interfaces;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities;

namespace TourismGuiding.Application.Features.Cities.Queries.GetById
{
    public class CitiesGetByIdHandler : IRequestHandler<CitiesGetByIdRequest, CitiesGetByIdResponse>
    {
        private readonly IBaseRepositories<City> rep;
        private readonly IMapper mapper;
        private readonly IHelper helper;

        public CitiesGetByIdHandler(IBaseRepositories<City> rep, IMapper mapper, IHelper helper)
        {
            this.rep = rep;
            this.mapper = mapper;
            this.helper = helper;
        }
        public async Task<CitiesGetByIdResponse> Handle(CitiesGetByIdRequest request, CancellationToken cancellationToken)
        {
            var repos = await rep.GetByIdAsync(request.CityId);

            var response = mapper.Map<CitiesGetByIdResponse>(repos); 

            return response;
        }
    }
}
