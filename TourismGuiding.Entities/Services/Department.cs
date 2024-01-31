using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Entities.NewFolder;

namespace TourismGuiding.Entities.Services
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string? Description { get; set; }
        public string? DepartmentType { get; set; }


        // Place
        public int PlaceId { get; set; }
        public Place Place { get; set; }

        public ICollection<Service>? Services { get; set; }

    }
}
