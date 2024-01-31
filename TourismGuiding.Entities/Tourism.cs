using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Entities
{
    public class Tourism
    {
        public int TourismId { get; set; }

        public string TourismName { get; set; }

        public string? Description { get; set; }

        public ICollection<Place>? Places { get; set; }

    }
}
