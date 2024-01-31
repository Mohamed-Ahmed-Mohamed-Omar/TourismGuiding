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

namespace TourismGuiding.Application.Features.Tourisms.Commends.Add
{
    public class TourismsAddHandler : IRequestHandler<TourismsAddRequest, ResponseGeneral>
    {
        private readonly IBaseRepositories<Tourism> rep;
        private readonly IMapper mapper;

        public TourismsAddHandler(IBaseRepositories<Tourism> rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }
        public async Task<ResponseGeneral> Handle(TourismsAddRequest request, CancellationToken cancellationToken)
        {
            var _mapper = mapper.Map<Tourism>(request);

            var response = await rep.AddAsync(_mapper);

            return response;
        }
    }
}
