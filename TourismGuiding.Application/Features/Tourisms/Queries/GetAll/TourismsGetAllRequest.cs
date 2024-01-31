using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Application.Features.Tourisms.Queries.GetAll
{
    public class TourismsGetAllRequest : IRequest<IEnumerable<TourismsGetAllResponse>>
    {
        // no thing
    }
}
