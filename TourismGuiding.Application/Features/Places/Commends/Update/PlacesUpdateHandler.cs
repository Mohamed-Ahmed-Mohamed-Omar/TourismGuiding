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

namespace TourismGuiding.Application.Features.Places.Commends.Update
{
    public class PlacesUpdateHandler : IRequestHandler<PlacesUpdateCommend,ResponseGeneral>
    {
        private readonly IBaseRepositories<Place> rep;
        private readonly IMapper mapper;

        public PlacesUpdateHandler(IBaseRepositories<Place> rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

        public async Task<ResponseGeneral> Handle(PlacesUpdateCommend request, CancellationToken cancellationToken)
        {
            var _mapper = mapper.Map<Place>(request);

            var response = await rep.UpdateAsync(_mapper);

            return response;
        }
    }
}
