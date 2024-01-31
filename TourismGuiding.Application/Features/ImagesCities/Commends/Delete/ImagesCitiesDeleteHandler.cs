using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;
using TourismGuiding.Application.Interfaces;
using TourismGuiding.Entities.NewFolder;

namespace TourismGuiding.Application.Features.ImagesCities.Commends.Delete
{
    public class ImagesCitiesDeleteHandler : IRequestHandler<ImagesCitiesDeleteRequest, ResponseGeneral>
    {
        private readonly IBaseRepositories<ImagesOfCity> rep;

        public ImagesCitiesDeleteHandler(IBaseRepositories<ImagesOfCity> rep)
        {
            this.rep = rep;
        }
        public async Task<ResponseGeneral> Handle(ImagesCitiesDeleteRequest request, CancellationToken cancellationToken)
        {
            var response = await rep.DeleteAsync(request.ImageId);

            return response;
        }
    }
}
