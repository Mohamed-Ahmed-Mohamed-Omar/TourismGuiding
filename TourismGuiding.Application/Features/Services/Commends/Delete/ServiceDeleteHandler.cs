using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities.Services;

namespace TourismGuiding.Application.Features.Services.Commends.Delete
{
    public class ServiceDeleteHandler : IRequestHandler<ServiceDeleteRequest, ResponseGeneral>
    {
        private readonly IBaseRepositories<Service> rep;
        public ServiceDeleteHandler(IBaseRepositories<Service> rep)
        {
            this.rep = rep;
        }
        public async Task<ResponseGeneral> Handle(ServiceDeleteRequest request, CancellationToken cancellationToken)
        {
            var response = await rep.DeleteAsync(request.ServiceId);

            return response;
        }
    }
}
