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

namespace TourismGuiding.Application.Features.Tourisms.Commends.Delete
{
    public class TourismsDeleteHandler : IRequestHandler<TourismsDeleteRequest, ResponseGeneral>
    {
        private readonly IBaseRepositories<Tourism> rep;

        public TourismsDeleteHandler(IBaseRepositories<Tourism> rep)
        {
            this.rep = rep;
        }
        public async Task<ResponseGeneral> Handle(TourismsDeleteRequest request, CancellationToken cancellationToken)
        {
            var response = await rep.DeleteAsync(request.TourismId);

            return response;
        }
    }
}
