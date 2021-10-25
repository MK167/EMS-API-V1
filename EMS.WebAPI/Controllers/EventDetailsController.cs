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
    public class EventDetailsController : BaseController
    {
        private readonly IEventDetailsService _Service;

        public EventDetailsController(IEventDetailsService service)
        {
            _Service = service;
        }

        [HttpGet("{ID}")]
        public IActionResult GetEventDetailsByID(Guid ID)
        {
            var Result = _Service.GetEventDetailsByID(ID);
            return Ok(Result);
        }

        [HttpGet]
        public IActionResult GetAllEventDetailss()
        {
            var Result = _Service.GetAllEventDetailss();
            return Ok(Result);
        }

        [HttpPost]
        public IActionResult AddEventDetails(EventDetailsDTO EventDetailsDTO)
        {
            var Result = _Service.AddEventDetails(EventDetailsDTO, out Message);
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
        public IActionResult UpdateEventDetails(EventDetailsDTO EventDetailsDTO)
        {
            var Result = _Service.UpdateEventDetails(EventDetailsDTO, out Message);
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
        public IActionResult DeleteEventDetails(Guid ID)
        {
            var Result = _Service.DeleteEventDetails(ID, out Message);
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
