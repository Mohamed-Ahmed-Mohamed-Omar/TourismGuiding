using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.Places.Commends.Add;
using TourismGuiding.Application.Features.ResponseGeneration;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities;
using TourismGuiding.Entities.Services;

namespace TourismGuiding.Application.Features.Departments.Commends.Add
{
    public class DepartmentAddHandler : IRequestHandler<DepartmentAddCommend,ResponseGeneral>
    {
        private readonly IBaseRepositories<Department> rep;
        private readonly IMapper mapper;

        public DepartmentAddHandler(IBaseRepositories<Department> rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

       
        public async Task<ResponseGeneral> Handle(DepartmentAddCommend request, CancellationToken cancellationToken)
        {
            var _mapper = mapper.Map<Department>(request);

            var response = await rep.AddAsync(_mapper);

            return response;
        }
    }
}
