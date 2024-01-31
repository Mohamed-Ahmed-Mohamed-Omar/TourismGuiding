using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Application.Features.Departments.Queries.GetById
{
    public class DepartmentGetByIdRequest : IRequest<DepartmentGetByIdResponse>
    {
        public int DepartmentId { get; set; }
    }
}
