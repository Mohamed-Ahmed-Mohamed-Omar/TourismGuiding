using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;

namespace TourismGuiding.Application.Features.Departments.Commends.Update
{
    public class DepartmentUpdateCommend : IRequest<ResponseGeneral>
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string? Description { get; set; }
        public string? DepartmentType { get; set; }


        // Place
        public int PlaceId { get; set; }
    }
}
