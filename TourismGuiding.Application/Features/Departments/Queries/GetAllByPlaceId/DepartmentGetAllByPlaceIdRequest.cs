using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Application.Features.Departments.Queries.GetAllByPlaceId
{
    public class DepartmentGetAllByPlaceIdRequest : IRequest<IEnumerable<DepartmentGetAllByPlaceIdResponse>>
    {
        public int PlaceId { get; set; }
    }
}
