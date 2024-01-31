using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourismGuiding.Application.Features.Cities.Commends.Add;
using TourismGuiding.Application.Features.Cities.Commends.Delete;
using TourismGuiding.Application.Features.Cities.Commends.Update;
using TourismGuiding.Application.Features.Cities.Queries.GetAll;
using TourismGuiding.Application.Features.Cities.Queries.GetById;
using TourismGuiding.Application.Features.Places.Commends.Add;
using TourismGuiding.Application.Features.Places.Commends.Delete;
using TourismGuiding.Application.Features.Places.Commends.Update;
using TourismGuiding.Application.Features.Places.Queries.GetAllByCityId;
using TourismGuiding.Application.Features.Places.Queries.GetById;

namespace TourismGuiding.Controllers.MainControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private readonly IMediator mediator;

        public PlacesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPost("AddPlace/{CityId}")]
        public async Task<IActionResult> AddPlace(int CityId, [FromBody] PlacesAddRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var commend = new PlacesAddCommend
            {
                CityId = CityId,
                Description = request.Description,
                EvaluationByStars = request.EvaluationByStars,
                Name = request.Name,
                phone = request.phone,
                PositionLink = request.PositionLink,
                TourismId = request.TourismId,
               
            };

            var response = await mediator.Send(commend);
            return Ok(response);
        }
        [HttpGet("GetById/{PlacesId}")]
        public async Task<IActionResult> GetById(int PlacesId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var commend = new PlacesGetByIdRequest() { PlaceId= PlacesId }; 

            var response = await mediator.Send(commend);

            return Ok(response);
        }


        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPut("updatePlace/{PlaceId}")]
        public async Task<IActionResult> UpdatePlace(int PlaceId, [FromBody] PlacesUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var commend = new PlacesUpdateCommend()
            {
                PlaceId = PlaceId,
                Description = request.Description,
                
                EvaluationByStars = request.EvaluationByStars,
                Name = request.Name,
                phone = request.phone,
                PositionLink = request.PositionLink,
                TourismId = request.TourismId
               
            };


            var response = await mediator.Send(commend);


            if (!response.Done)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }

        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpDelete("deletePlace/{PlaceId}")]
        public async Task<IActionResult> DeletePlace(int PlaceId)
        {
            var request = new PlacesDeleteRequest { PlaceId = PlaceId };

            var response = await mediator.Send(request);

            if (!response.Done)
                return BadRequest(response.Message);

            return Ok(response);
        }
        [HttpGet("getPlacesByCityId/{CityId}")]
        public async Task<IActionResult> GetPlacesByCityId(int CityId)
        {
            var request = new PlacesGetAllByCityIdRequest { CityId = CityId };

            var response = await mediator.Send(request);

            return Ok(response);
        }


    }
}
