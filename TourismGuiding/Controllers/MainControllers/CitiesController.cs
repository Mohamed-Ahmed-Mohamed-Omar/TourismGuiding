using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;
using TourismGuiding.Application.Features.Cities.Commends.Add;
using TourismGuiding.Application.Features.Cities.Commends.Delete;
using TourismGuiding.Application.Features.Cities.Commends.Update;
using TourismGuiding.Application.Features.Cities.Queries.GetById;
using TourismGuiding.Application.Features.Cities.Queries.GetAll;
using Microsoft.AspNetCore.Authorization;

namespace TourismGuiding.Controllers.MainControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly IMediator mediator;

        public CitiesController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet("getCities")]
        public async Task<IActionResult> GetCities()
        {
            var request = new CitiesGetAllRequest();

            var response = await mediator.Send(request);

            return Ok(response);
        }
        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPost("addCity")]
        public async Task<IActionResult> AddCity([FromBody] CitiesAddRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await mediator.Send(request);

            if (!response.Done)
            {
                return BadRequest(response.Message);
            }

           
            return Ok(response);
        }
        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPut("updateCity/{CityId}")]
        public async Task<IActionResult> UpdateCity(int CityId, [FromBody] CitiesUpdateRequest request)
        {
            var commend = new CitiesUpdateCommend()
            {
                CityId = CityId,
                CityName = request.CityName,
                Description= request.Description,
                PositionLink= request.PositionLink

            };
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await mediator.Send(commend);


            if (!response.Done)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }

        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpDelete("deleteCity/{CityId}")]
        public async Task<IActionResult> DeleteCity(int CityId)
        {
            var request = new CitiesDeleteRequest { CityId = CityId };

            var response = await mediator.Send(request);

            if (!response.Done)
                return BadRequest(response.Message);

            return Ok(response);
        }


        [HttpGet("getById/{CityId}")]
        public async Task<IActionResult> GetById(int CityId)
        {
            var request = new CitiesGetByIdRequest { CityId = CityId };

            var response = await mediator.Send(request);



            return Ok(response);
        }
    }
}
