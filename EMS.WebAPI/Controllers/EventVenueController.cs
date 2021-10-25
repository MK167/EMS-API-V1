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
    public class EventVenueController : BaseController
    {
        private readonly IEventVenueService _Service;

        public EventVenueController(IEventVenueService service)
        {
            _Service = service;
        }

        [HttpGet("{ID}")]
        public IActionResult GetEventVenueByID(Guid ID)
        {
            var Result = _Service.GetEventVenueByID(ID);
            return Ok(Result);
        }

        [HttpGet]
        public IActionResult GetAllEventVenues()
        {
            var Result = _Service.GetAllEventVenues();
            return Ok(Result);
        }

        [HttpPost]
        public IActionResult AddEventVenue(EventVenueDTO EventVenueDTO)
        {
            var Result = _Service.AddEventVenue(EventVenueDTO, out Message);
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
        public IActionResult UpdateEventVenue(EventVenueDTO EventVenueDTO)
        {
            var Result = _Service.UpdateEventVenue(EventVenueDTO, out Message);
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
        public IActionResult DeleteEventVenue(Guid ID)
        {
            var Result = _Service.DeleteEventVenue(ID, out Message);
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

