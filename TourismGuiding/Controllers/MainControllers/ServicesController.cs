using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourismGuiding.Application.Features.Departments.Commends.Add;
using TourismGuiding.Application.Features.Departments.Commends.Delete;
using TourismGuiding.Application.Features.Departments.Commends.Update;
using TourismGuiding.Application.Features.Departments.Queries.GetAllByPlaceId;
using TourismGuiding.Application.Features.Departments.Queries.GetById;
using TourismGuiding.Application.Features.Services.Commends.Add;
using TourismGuiding.Application.Features.Services.Commends.Delete;
using TourismGuiding.Application.Features.Services.Queries.GetAllByDepartmentId;

namespace TourismGuiding.Controllers.MainControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public ServicesController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPost("AddService/{DepartmentId}")]
        public async Task<IActionResult> AddService(int DepartmentId, [FromBody] ServiceAddRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var commend = mapper.Map<ServiceAddCommend>(request);

            commend.DepartmentId = DepartmentId;
            var response = await mediator.Send(commend);
            if (!response.Done)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }
        //[HttpGet("GetById/{DepartmentId}")]
        //public async Task<IActionResult> GetById(int DepartmentId)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var commend = new DepartmentGetByIdRequest() { DepartmentId = DepartmentId };

        //    var response = await mediator.Send(commend);

        //    return Ok(response);
        //}


        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpDelete("deleteService/{ServiceId}")]
        public async Task<IActionResult> DeleteService(int ServiceId)
        {
            var request = new ServiceDeleteRequest { ServiceId = ServiceId };

            var response = await mediator.Send(request);

            if (!response.Done)
                return BadRequest(response.Message);

            return Ok(response);
        }
        [HttpGet("getServicesByDepartmentId/{DepartmentId}")]
        public async Task<IActionResult> GetServicesByDepartmentId(int DepartmentId)
        {
            var request = new ServiceGetAllByDepartmentIdRequest { DepartmentId = DepartmentId };

            var response = await mediator.Send(request);

            return Ok(response);
        }
    }
}
