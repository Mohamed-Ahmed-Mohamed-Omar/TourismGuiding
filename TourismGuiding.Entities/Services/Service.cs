using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Entities.NewFolder;

namespace TourismGuiding.Entities.Services
{
    public class Service
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public string? Type { get; set; }

        public decimal? Price { get; set; }


            // Department

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
