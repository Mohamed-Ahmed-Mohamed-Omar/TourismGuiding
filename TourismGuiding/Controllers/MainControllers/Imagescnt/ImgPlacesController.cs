using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourismGuiding.Application.Features.ImagesCities.Commends.Add;
using TourismGuiding.Application.Features.ImagesCities.Commends.Delete;
using TourismGuiding.Application.Features.ImagesCities.Queries.GetAll;
using TourismGuiding.Application.Features.ImagesPlaces.Commends.Add;
using TourismGuiding.Application.Features.ImagesPlaces.Commends.Delete;
using TourismGuiding.Application.Features.ImagesPlaces.Queries.GetAll;

namespace TourismGuiding.Controllers.MainControllers.Imagescnt
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImgPlacesController : ControllerBase
    {
        private readonly IMediator mediator;

        public ImgPlacesController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpPost("addImage/{PlaceId}")]
        public async Task<IActionResult> AddImage(int PlaceId, ImagesPlacesAddRequest request)
        {
            var commend = new ImagesPlacesAddCommend()
            {
                PlaceId = PlaceId,
                ImageUrl = request.ImageUrl
            };

            var response = await mediator.Send(commend);

            return Ok(response);
        }

        [HttpDelete("deleteImage/{ImageId}")]
        public async Task<IActionResult> DeleteImage(int ImageId)
        {
            var request = new ImagesPlacesDeleteRequest()
            {
                ImageId = ImageId

            };

            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("getImagesByPlaceId/{PlaceId}")]
        public async Task<IActionResult> GetImagesByCityId(int PlaceId)
        {
            var request = new ImagesPlacesGetAllRequest()
            {
                PlaceId = PlaceId

            };

            var response = await mediator.Send(request);

            return Ok(response);
        }
    }
}
