using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;

namespace TourismGuiding.Application.Features.Departments.Commends.Add
{
    public class DepartmentAddCommend : IRequest<ResponseGeneral>
    {
        public string DepartmentName { get; set; }
        public string? Description { get; set; }
        public string? DepartmentType { get; set; }


        // Place
        public int PlaceId { get; set; }
    }
}
