using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using webapi.Dto;
using webapi.Services;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/status")] // api/users
    public class StatusController : ControllerBase
    {
        private readonly IStatusService _statusService;

        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<StatusDto> status = await _statusService.FindAll();
            return Ok(status);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(int id)
        {
            StatusDto? statusDto = await _statusService.FindById(id);
            return statusDto != null ? Ok(statusDto) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Register(StatusDto statusDto)
        {
            try
            {
                await _statusService.Insert(statusDto);
                return Created(Request.GetDisplayUrl(), statusDto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, StatusDto statusDto)
        {
            if (id != statusDto.Id) return BadRequest();
            _statusService.Update(statusDto);
            return NoContent();
        }

    }
}