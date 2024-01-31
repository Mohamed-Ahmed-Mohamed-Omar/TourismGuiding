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

namespace TourismGuiding.Application.Features.Cities.Queries.GetAll
{
    public class CitiesGetAllHandler : IRequestHandler<CitiesGetAllRequest, IEnumerable<CitiesGetAllResponse>>
    {
        private readonly IBaseRepositories<City> rep;
        private readonly IMapper mapper;
       

        public CitiesGetAllHandler(IBaseRepositories<City> rep, IMapper mapper)
        {
            this.rep = rep;

            this.mapper = mapper;
        }
        public async Task<IEnumerable<CitiesGetAllResponse>> Handle(CitiesGetAllRequest request, CancellationToken cancellationToken)
        {
            var allRows = await rep.GetAllAsync();

            var response = mapper.ProjectTo<CitiesGetAllResponse>(allRows.AsQueryable());

            return response;
        }
    }
}
