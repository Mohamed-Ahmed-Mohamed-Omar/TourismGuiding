using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;

namespace TourismGuiding.Application.Features.Services.Commends.Add
{
    public class ServiceAddCommend : IRequest<ResponseGeneral>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }

        public decimal? Price { get; set; }

        // Department

        public int DepartmentId { get; set; }
    }
}
