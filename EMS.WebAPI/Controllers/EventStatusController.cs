using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.Services.DTO;
using EMS.Services.Interfaces;
using EMS.WebAPI.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
namespace EMS.WebAPI.Controllers
{
    public class EventStatusController : BaseController
    {
        private readonly IEventStatusService _Service;

        public EventStatusController(IEventStatusService service)
        {
            _Service = service;
        }

        [HttpGet("{ID}")]
        public IActionResult GetEventStatusByID(Guid ID)
        {
            var Result = _Service.GetEventStatusByID(ID);
            return Ok(Result);
        }

        [HttpGet]
        public IActionResult GetAllEventStatuss()
        {
            var Result = _Service.GetAllEventStatuss();
            return Ok(Result);
        }

        [HttpPost]
        public IActionResult AddEventStatus(EventStatusDTO EventStatusDTO)
        {
            var Result = _Service.AddEventStatus(EventStatusDTO, out Message);
            if (Result == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult UpdateEventStatus(EventStatusDTO EventStatusDTO)
        {
            var Result = _Service.UpdateEventStatus(EventStatusDTO, out Message);
            if (Result == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{ID}")]
        public IActionResult DeleteEventStatus(Guid ID)
        {
            var Result = _Service.DeleteEventStatus(ID, out Message);
            if (Result == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

