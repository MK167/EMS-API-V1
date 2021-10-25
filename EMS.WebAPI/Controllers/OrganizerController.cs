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
    public class OrganizerController : BaseController
    {
        private readonly IOrganizerService _Service;

        public OrganizerController(IOrganizerService service)
        {
            _Service = service;
        }

        [HttpGet("{ID}")]
        public IActionResult GetOrganizerByID(Guid ID)
        {
            var Result = _Service.GetOrganizerByID(ID);
            return Ok(Result);
        }

        [HttpGet]
        public IActionResult GetAllOrganizers()
        {
            var Result = _Service.GetAllOrganizers();
            return Ok(Result);
        }

        [HttpPost]
        public IActionResult AddOrganizer(OrganizerDTO OrganizerDTO)
        {
            var Result = _Service.AddOrganizer(OrganizerDTO, out Message);
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
        public IActionResult UpdateOrganizer(OrganizerDTO OrganizerDTO)
        {
            var Result = _Service.UpdateOrganizer(OrganizerDTO, out Message);
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
        public IActionResult DeleteOrganizer(Guid ID)
        {
            var Result = _Service.DeleteOrganizer(ID, out Message);
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

