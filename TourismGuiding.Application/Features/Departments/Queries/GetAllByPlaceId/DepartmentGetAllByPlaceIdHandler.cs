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
using TourismGuiding.Entities.Services;

namespace TourismGuiding.Application.Features.Departments.Queries.GetAllByPlaceId
{
    public class DepartmentGetAllByPlaceIdHandler : IRequestHandler<DepartmentGetAllByPlaceIdRequest, IEnumerable<DepartmentGetAllByPlaceIdResponse>>
    {
        private readonly IMapper mapper;
        private readonly IHelper helper;

        public DepartmentGetAllByPlaceIdHandler( IMapper mapper, IHelper helper)
        {
          
            this.mapper = mapper;
            this.helper = helper;
        }

        public async Task<IEnumerable<DepartmentGetAllByPlaceIdResponse>> Handle(DepartmentGetAllByPlaceIdRequest request, CancellationToken cancellationToken)
        {
            var allRows = await helper.GetDepartmentsById(request.PlaceId);
            var response = mapper.ProjectTo<DepartmentGetAllByPlaceIdResponse>(allRows.AsQueryable());

            return response;
        }
    }
}
