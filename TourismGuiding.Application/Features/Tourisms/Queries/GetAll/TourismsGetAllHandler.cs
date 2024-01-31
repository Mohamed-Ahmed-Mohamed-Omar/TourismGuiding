using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.Cities.Queries.GetAll;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities;

namespace TourismGuiding.Application.Features.Tourisms.Queries.GetAll
{
    public class TourismsGetAllHandler : IRequestHandler<TourismsGetAllRequest, IEnumerable<TourismsGetAllResponse>>
    {
        private readonly IBaseRepositories<Tourism> rep;
        private readonly IMapper mapper;

        public TourismsGetAllHandler(IBaseRepositories<Tourism> rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<TourismsGetAllResponse>> Handle(TourismsGetAllRequest request, CancellationToken cancellationToken)
        {
            var allRows = await rep.GetAllAsync();
            var response = mapper.ProjectTo<TourismsGetAllResponse>(allRows.AsQueryable());

            return response;
        }
    }
}
