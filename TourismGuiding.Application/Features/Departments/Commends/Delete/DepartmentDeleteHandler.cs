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

namespace TourismGuiding.Application.Features.Departments.Commends.Delete
{
    public class DepartmentDeleteHandler : IRequestHandler<DepartmentDeleteRequest, ResponseGeneral>
    {
        private readonly IBaseRepositories<Department> rep;

        public DepartmentDeleteHandler(IBaseRepositories<Department> rep)
        {
            this.rep = rep; 
        }
        public async Task<ResponseGeneral> Handle(DepartmentDeleteRequest request, CancellationToken cancellationToken)
        {
           

            var response = await rep.DeleteAsync(request.DepartmentId);

            return response;
        }
    }
}
