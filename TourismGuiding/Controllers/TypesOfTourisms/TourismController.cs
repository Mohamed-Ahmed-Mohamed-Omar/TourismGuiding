using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TourismGuiding.Application.Features.Places.Queries.GetAllByTourismId;
using TourismGuiding.Application.Features.Tourisms.Commends.Add;
using TourismGuiding.Application.Features.Tourisms.Commends.Delete;
using TourismGuiding.Application.Features.Tourisms.Commends.Update;
using TourismGuiding.Application.Features.Tourisms.Queries.GetAll;
using TourismGuiding.Application.Features.Tourisms.Queries.GetById;

namespace TourismGuiding.Controllers.TypesOfTourisms
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourismController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public TourismController(IMediator mediator,IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }


        [HttpGet("getTourisms")]
        public async Task<IActionResult> GetTourisms()
        {
            var request = new TourismsGetAllRequest();

            var response = await mediator.Send(request);

            return Ok(response);
        }

        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPost("addTourism")]
        public async Task<IActionResult> AddTourism([FromBody] TourismsAddRequest request)
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
        [HttpPut("updateTourism/{TourismId}")]
        public async Task<IActionResult> UpdateCity(int TourismId, [FromBody] TourismsUpdateRequest request)
        {
            var commend = mapper.Map<TourismsUpdateCommend>(request);
            
            commend.TourismId=TourismId;

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
        [HttpDelete("deleteTourism/{TourismId}")]
        public async Task<IActionResult> DeleteTourism(int TourismId)
        {
            var request = new TourismsDeleteRequest { TourismId = TourismId };

            var response = await mediator.Send(request);

            if (!response.Done)
                return BadRequest(response.Message);

            return Ok(response);
        }

        [HttpGet("getById/{TourismId}")]
        public async Task<IActionResult> GetById(int TourismId)
        {
            var request = new TourismsGetByIdRequest { TourismId = TourismId };

            var response = await mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("getPlacesByTourismId/{TourismId}")]
        public async Task<IActionResult> GetPlacesByCityId(int TourismId)
        {
            var request = new PlacesGetAllByTourismIdRequest { TourismId = TourismId };

            var response = await mediator.Send(request);

            return Ok(response);
        }
    }
}
