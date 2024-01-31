using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Application.Features.Tourisms.Queries.GetById
{
    public class TourismsGetByIdRequest : IRequest<TourismsGetByIdResponse>
    {
        public int TourismId { get; set; }
    }
}
