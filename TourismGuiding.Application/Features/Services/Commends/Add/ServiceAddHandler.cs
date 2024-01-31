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
using TourismGuiding.Entities.Services;

namespace TourismGuiding.Application.Features.Services.Commends.Add
{
    public class ServiceAddHandler : IRequestHandler<ServiceAddCommend, ResponseGeneral>
    {
        private readonly IBaseRepositories<Service> rep;
        private readonly IMapper mapper;

        public ServiceAddHandler(IBaseRepositories<Service> rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

        public async Task<ResponseGeneral> Handle(ServiceAddCommend request, CancellationToken cancellationToken)
        {
            var _mapper = mapper.Map<Service>(request);

            var response = await rep.AddAsync(_mapper);

            return response;
        }
    }
}
