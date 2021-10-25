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
    public class EventCategoryController : BaseController
    {
        private readonly IEventCategoryService _Service;

        public EventCategoryController(IEventCategoryService service)
        {
            _Service = service;
        }

        [HttpGet("{ID}")]
        public IActionResult GetEventCategoryByID(Guid ID)
        {
            var Result = _Service.GetEventCategoryByID(ID);
            return Ok(Result);
        }

        [HttpGet]
        public IActionResult GetAllEventCategorys()
        {
            var Result = _Service.GetAllEventCategorys();
            return Ok(Result);
        }

        [HttpPost]
        public IActionResult AddEventCategory(EventCategoryDTO EventCategoryDTO)
        {
            var Result = _Service.AddEventCategory(EventCategoryDTO, out Message);
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
        public IActionResult UpdateEventCategory(EventCategoryDTO EventCategoryDTO)
        {
            var Result = _Service.UpdateEventCategory(EventCategoryDTO, out Message);
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
        public IActionResult DeleteEventCategory(Guid ID)
        {
            var Result = _Service.DeleteEventCategory(ID, out Message);
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
