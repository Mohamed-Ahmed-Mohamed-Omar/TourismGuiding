using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Application.Features.Departments.Queries.GetAllByPlaceId
{
    public class DepartmentGetAllByPlaceIdResponse
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string? DepartmentType { get; set; }
    }
}
