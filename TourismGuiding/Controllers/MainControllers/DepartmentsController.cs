using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourismGuiding.Application.Features.Departments.Commends.Add;
using TourismGuiding.Application.Features.Departments.Commends.Delete;
using TourismGuiding.Application.Features.Departments.Commends.Update;
using TourismGuiding.Application.Features.Departments.Queries.GetAllByPlaceId;
using TourismGuiding.Application.Features.Departments.Queries.GetById;
using TourismGuiding.Application.Features.Places.Commends.Add;
using TourismGuiding.Application.Features.Places.Commends.Delete;
using TourismGuiding.Application.Features.Places.Commends.Update;
using TourismGuiding.Application.Features.Places.Queries.GetById;

namespace TourismGuiding.Controllers.MainControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IMediator mediator;

        public DepartmentsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPost("AddDepartment/{PlaceId}")] 
        public async Task<IActionResult> AddDepartment(int PlaceId, [FromBody] DepartmentAddRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var commend = new DepartmentAddCommend
            {
                PlaceId = PlaceId,
                Description = request.Description,
                DepartmentType = request.DepartmentType,
                DepartmentName = request.DepartmentName
            };

            var response = await mediator.Send(commend);
            if (!response.Done)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }
        
        
        [HttpGet("GetById/{DepartmentId}")]
        public async Task<IActionResult> GetById(int DepartmentId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var commend = new DepartmentGetByIdRequest() { DepartmentId = DepartmentId };

            var response = await mediator.Send(commend);

            return Ok(response);
        }

        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPut("updateDepartment/{DepartmentId}")]
        public async Task<IActionResult> UpdateDepartment(int DepartmentId, [FromBody] DepartmentUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var commend = new DepartmentUpdateCommend()
            {
                DepartmentId = DepartmentId,
                Description = request.Description,
                DepartmentType = request.DepartmentType,
                DepartmentName = request.DepartmentName,
                PlaceId = request.PlaceId

            };

            var response = await mediator.Send(commend);

            if (!response.Done)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }

        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpDelete("deleteDepartment/{DepartmentId}")]
        public async Task<IActionResult> DeleteDepartment(int DepartmentId)
        {
            var request = new DepartmentDeleteRequest { DepartmentId = DepartmentId };

            var response = await mediator.Send(request);

            if (!response.Done)
                return BadRequest(response.Message);

            return Ok(response);
        }

     
        [HttpGet("getDepartmentsByPlaceId/{PlaceId}")]
        public async Task<IActionResult> GetDepartmentsByPlaceId(int PlaceId)
        {
            var request = new DepartmentGetAllByPlaceIdRequest { PlaceId = PlaceId };

            var response = await mediator.Send(request);

            return Ok(response);
        }
    }
}
