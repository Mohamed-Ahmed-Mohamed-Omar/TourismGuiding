using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTeacher.Application.Interfaces;
using TourismGuiding.Application.Features.Places.Queries.GetAll;

namespace TourismGuiding.Application.Features.Places.Queries.GetAllByTourismId
{
    public class PlacesGetAllByTourismIdHandler : IRequestHandler<PlacesGetAllByTourismIdRequest, IEnumerable<PlacesGetAllByTourismIdResponse>>
    {
      
        private readonly IHelper helper;

        public PlacesGetAllByTourismIdHandler(IHelper helper)
        { 
            this.helper = helper;
        }
        public async Task<IEnumerable<PlacesGetAllByTourismIdResponse>> Handle(PlacesGetAllByTourismIdRequest request, CancellationToken cancellationToken)
        {
            var response = await helper.GetPlacesByTourismId(request.TourismId);

            return response;
        }
    }
}
