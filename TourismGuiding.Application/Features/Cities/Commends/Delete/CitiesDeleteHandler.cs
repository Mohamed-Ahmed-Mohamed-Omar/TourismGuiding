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

namespace TourismGuiding.Application.Features.Cities.Commends.Delete
{
    public class CitiesDeleteHandler : IRequestHandler<CitiesDeleteRequest, ResponseGeneral>
    {
        private readonly IBaseRepositories<City> rep;
        private readonly IMapper mapper;


        public CitiesDeleteHandler(IBaseRepositories<City> rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }
        public async Task<ResponseGeneral> Handle(CitiesDeleteRequest request, CancellationToken cancellationToken)
        {

            var response = await rep.DeleteAsync(request.CityId);

            return response;
        }
    }
}
