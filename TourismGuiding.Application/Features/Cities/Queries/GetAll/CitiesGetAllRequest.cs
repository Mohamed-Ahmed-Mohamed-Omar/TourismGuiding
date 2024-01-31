using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Application.Features.Cities.Queries.GetAll
{
    public class CitiesGetAllRequest : IRequest<IEnumerable<CitiesGetAllResponse>>
    {
        // no thing
    }
}
