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
    public class GenderController : BaseController
    {
        private readonly IGenderService _Service;

        public GenderController(IGenderService service)
        {
            _Service = service;
        }

        [HttpGet("{ID}")]
        public IActionResult GetGenderByID(Guid ID)
        {
            var Result = _Service.GetGenderByID(ID);
            return Ok(Result);
        }

        [HttpGet]
        public IActionResult GetAllGenders()
        {
            var Result = _Service.GetAllGenders();
            return Ok(Result);
        }

        [HttpPost]
        public IActionResult AddGender(GenderDTO GenderDTO)
        {
            var Result = _Service.AddGender(GenderDTO, out Message);
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
        public IActionResult UpdateGender(GenderDTO GenderDTO)
        {
            var Result = _Service.UpdateGender(GenderDTO, out Message);
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
        public IActionResult DeleteGender(Guid ID)
        {
            var Result = _Service.DeleteGender(ID, out Message);
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

