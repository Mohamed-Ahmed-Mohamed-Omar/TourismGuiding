using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;

namespace TourismGuiding.Application.Features.Tourisms.Commends.Delete
{
    public class TourismsDeleteRequest : IRequest<ResponseGeneral>
    {
        public int TourismId { get; set; }
    }
}
