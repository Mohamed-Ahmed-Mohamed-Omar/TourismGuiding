using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTeacher.Application.Interfaces;
using TourismGuiding.Application.Features.Cities.Queries.GetAll;
using TourismGuiding.Application.Features.Places.Queries.GetAllByCityId;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities;

namespace TourismGuiding.Application.Features.Places.Queries.GetAll
{
    public class PlacesGetAllByCityIdHandler : IRequestHandler<PlacesGetAllByCityIdRequest, IEnumerable<PlacesGetAllByCityIdResponse>>
    {
        private readonly IMapper mapper;

        private readonly IHelper helper;

        public PlacesGetAllByCityIdHandler(IMapper mapper, IHelper helper)
        {
            this.mapper = mapper;
            this.helper = helper;
        }
        public async Task<IEnumerable<PlacesGetAllByCityIdResponse>> Handle(PlacesGetAllByCityIdRequest request, CancellationToken cancellationToken)
        {
            var response = await helper.GetPlacesById(request.CityId);
            //var response = mapper.ProjectTo<PlacesGetAllByCityIdResponse>(allRows.AsQueryable());

            return response;
        }
    }
}
