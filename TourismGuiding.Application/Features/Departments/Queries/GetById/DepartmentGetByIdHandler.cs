using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities;
using TourismGuiding.Entities.Services;

namespace TourismGuiding.Application.Features.Departments.Queries.GetById
{
    public class DepartmentGetByIdHandler : IRequestHandler<DepartmentGetByIdRequest, DepartmentGetByIdResponse>
    {
        private readonly IBaseRepositories<Department> rep;
        private readonly IMapper mapper;

        public DepartmentGetByIdHandler(IBaseRepositories<Department> rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }
        public async Task<DepartmentGetByIdResponse> Handle(DepartmentGetByIdRequest request, CancellationToken cancellationToken)
        {
          

            var respo = await rep.GetByIdAsync(request.DepartmentId);

            var response = mapper.Map<DepartmentGetByIdResponse>(respo);

            return response;
        }
    }
}
