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

namespace TourismGuiding.Application.Features.Places.Commends.Delete
{
    public class PlacesDeleteHandler :IRequestHandler<PlacesDeleteRequest,ResponseGeneral>
    {
        private readonly IBaseRepositories<Place> rep;
        private readonly IMapper mapper;

        public PlacesDeleteHandler(IBaseRepositories<Place> rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

        public async Task<ResponseGeneral> Handle(PlacesDeleteRequest request, CancellationToken cancellationToken)
        {
            var response = await rep.DeleteAsync(request.PlaceId);

            return response;
        }
    }
}
