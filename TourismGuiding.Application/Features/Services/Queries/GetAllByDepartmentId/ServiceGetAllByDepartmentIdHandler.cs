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
using TourismGuiding.Entities.Services;

namespace TourismGuiding.Application.Features.Services.Queries.GetAllByDepartmentId
{
    public class ServiceGetAllByDepartmentIdHandler : IRequestHandler<ServiceGetAllByDepartmentIdRequest, IEnumerable<ServiceGetAllByDepartmentIdResponse>>
    {

        private readonly IBaseRepositories<Service> rep;
        private readonly IMapper mapper;
        private readonly IHelper helper;

        public ServiceGetAllByDepartmentIdHandler(IBaseRepositories<Service> rep, IMapper mapper, IHelper helper)
        {
            this.rep = rep;
            this.mapper = mapper;
            this.helper = helper;
        }

        public async Task<IEnumerable<ServiceGetAllByDepartmentIdResponse>> Handle(ServiceGetAllByDepartmentIdRequest request, CancellationToken cancellationToken)
        {
            var allRows = await helper.GetServicesById(request.DepartmentId);
            var response = mapper.ProjectTo<ServiceGetAllByDepartmentIdResponse>(allRows.AsQueryable());

            return response;
        }
    }
}
