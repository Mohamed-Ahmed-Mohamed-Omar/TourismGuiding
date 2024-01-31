using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;

namespace TourismGuiding.Application.Features.Services.Commends.Delete
{
    public class ServiceDeleteRequest : IRequest<ResponseGeneral>
    {
        public int ServiceId { get; set; }
    }
}
