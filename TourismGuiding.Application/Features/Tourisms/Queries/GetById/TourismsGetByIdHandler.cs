using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTeacher.Application.Interfaces;
using TourismGuiding.Application.Features.Cities.Queries.GetById;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities;

namespace TourismGuiding.Application.Features.Tourisms.Queries.GetById
{
    public class TourismsGetByIdHandler : IRequestHandler<TourismsGetByIdRequest, TourismsGetByIdResponse>
    {
        private readonly IBaseRepositories<Tourism> rep;
        private readonly IMapper mapper;
        public TourismsGetByIdHandler(IBaseRepositories<Tourism> rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }
        public async Task<TourismsGetByIdResponse> Handle(TourismsGetByIdRequest request, CancellationToken cancellationToken)
        {
            var repos = await rep.GetByIdAsync(request.TourismId);
            var response = mapper.Map<TourismsGetByIdResponse>(repos);
            return response;
        }
    }
}
