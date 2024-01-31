using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;

namespace TourismGuiding.Application.Features.Departments.Commends.Delete
{
    public class DepartmentDeleteRequest : IRequest<ResponseGeneral>
    {
        public int DepartmentId { get; set; }
    }
}
