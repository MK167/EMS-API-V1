using EMS.Services.DTO;
using EMS.Services.Interfaces;
using EMS.WebAPI.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.WebAPI.Controllers
{
    public class EventAttendanceController : BaseController
    {
        private readonly IEventAttendanceService _Service;

        public EventAttendanceController(IEventAttendanceService service)
        {
            _Service = service;
        }
        
        [HttpGet("{ID}")]
        public IActionResult GetEventAttendanceByID(Guid ID)
        {
            var Result = _Service.GetEventAttendanceByID(ID);
            return Ok(Result);
        }

        [HttpGet]
        public IActionResult GetAllEventAttendances()
        {
            var Result = _Service.GetAllEventAttendances();
            return Ok(Result);
        }

        [HttpPost]
        public IActionResult AddEventAttendance(EventAttendanceDTO EventAttendanceDTO)
        {
            var Result = _Service.AddEventAttendance(EventAttendanceDTO, out Message);
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
        public IActionResult UpdateEventAttendance(EventAttendanceDTO EventAttendanceDTO)
        {
            var Result = _Service.UpdateEventAttendance(EventAttendanceDTO, out Message);
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
        public IActionResult DeleteEventAttendance(Guid ID)
        {
            var Result = _Service.DeleteEventAttendance(ID, out Message);
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
