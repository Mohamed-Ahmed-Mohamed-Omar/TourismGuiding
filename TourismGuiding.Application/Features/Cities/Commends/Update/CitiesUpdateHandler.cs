using AutoMapper;
using MediatR;
using TourismGuiding.Application.Features.ResponseGeneration;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities;

namespace TourismGuiding.Application.Features.Cities.Commends.Update
{
    public class CitiesUpdateHandler : IRequestHandler<CitiesUpdateCommend, ResponseGeneral>
    {
        private readonly IBaseRepositories<City> rep;
        private readonly IMapper mapper;

        public CitiesUpdateHandler(IBaseRepositories<City> rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }
        public async Task<ResponseGeneral> Handle(CitiesUpdateCommend request, CancellationToken cancellationToken)
        {
            var _mapper = mapper.Map<City>(request);

            var response = await rep.UpdateAsync(_mapper);

            return response;
        }
    }
}
