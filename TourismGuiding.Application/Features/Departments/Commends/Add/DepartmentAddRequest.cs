using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Application.Features.Departments.Commends.Add
{
    public class DepartmentAddRequest
    {
        public string DepartmentName { get; set; }
        public string? Description { get; set; }
        public string? DepartmentType { get; set; }


    }
}
