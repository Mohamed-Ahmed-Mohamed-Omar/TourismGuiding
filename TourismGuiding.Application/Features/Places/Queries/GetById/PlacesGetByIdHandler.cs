using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTeacher.Application.Interfaces;
using TourismGuiding.Application.Features.Places.Queries.GetAll;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities;

namespace TourismGuiding.Application.Features.Places.Queries.GetById
{
    public class PlacesGetByIdHandler : IRequestHandler<PlacesGetByIdRequest, PlacesGetByIdResponse>
    {
        private readonly IBaseRepositories<Place> rep;
        private readonly IMapper mapper;
        private readonly IHelper helper;

        public PlacesGetByIdHandler(IBaseRepositories<Place> rep, IMapper mapper, IHelper helper)
        {
            this.rep = rep;
            this.mapper = mapper;
            this.helper = helper;
        }
        public async Task<PlacesGetByIdResponse> Handle(PlacesGetByIdRequest request, CancellationToken cancellationToken)
        {
            var resp = await rep.GetByIdAsync(request.PlaceId);
            var response = mapper.Map<PlacesGetByIdResponse>(resp);

            response.TourismId = await helper.GetTourismName(response.TourismId);


            return response;

        }
    }
}
