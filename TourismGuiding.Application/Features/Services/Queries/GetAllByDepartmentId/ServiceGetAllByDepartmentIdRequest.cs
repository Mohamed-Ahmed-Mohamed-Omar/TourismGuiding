using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Application.Features.Services.Queries.GetAllByDepartmentId
{
    public class ServiceGetAllByDepartmentIdRequest : IRequest<IEnumerable<ServiceGetAllByDepartmentIdResponse>>
    {
        public int DepartmentId { get; set; }
    }
}
