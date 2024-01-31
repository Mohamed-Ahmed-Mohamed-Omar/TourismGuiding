using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities.NewFolder;

namespace TourismGuiding.Application.Features.ImagesPlaces.Commends.Delete
{
    public class ImagesPlacesDeleteHandler : IRequestHandler<ImagesPlacesDeleteRequest,ResponseGeneral>
    {
        private readonly IBaseRepositories<ImagesOfCity> rep;



        public ImagesPlacesDeleteHandler(IBaseRepositories<ImagesOfCity> rep)
        {
            this.rep = rep;
        }

        public async Task<ResponseGeneral> Handle(ImagesPlacesDeleteRequest request, CancellationToken cancellationToken)
        {
            var response = await rep.DeleteAsync(request.ImageId);

            return response;
        }
    }
}
