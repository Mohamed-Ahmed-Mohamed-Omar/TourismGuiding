using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourismGuiding.Application.Features.ImagesCities.Commends.Add;
using TourismGuiding.Application.Features.ImagesCities.Commends.Delete;
using TourismGuiding.Application.Features.ImagesCities.Queries.GetAll;

namespace TourismGuiding.Controllers.MainControllers.Imagescnt
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImgCityController : ControllerBase
    {
        private readonly IMediator mediator;

        public ImgCityController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpPost("addImage/{CityId}")]
        public async Task<IActionResult> AddImage(int CityId, ImagesCitiesAddRequest request)
        {
            var commend = new ImagesCitiesAddCommend()
            {
                CityId = CityId,

                ImageUrl = request.ImageUrl
            };

            var response = await mediator.Send(commend);

            return Ok(response);
        }

        [HttpDelete("deleteImage/{ImageId}")]
        public async Task<IActionResult> DeleteImage(int ImageId)
        {
            var request = new ImagesCitiesDeleteRequest()
            {
                ImageId = ImageId
            };

            var response = await mediator.Send(request);

            return Ok(response);
        }
        [HttpGet("getImagesByCityId/{CityId}")]
        public async Task<IActionResult> GetImagesByCityId(int CityId)
        {
            var request = new ImagesCitiesGetAllRequest()
            {
                CityId = CityId
            };

            var response = await mediator.Send(request);

            return Ok(response);
        }
    }
}
