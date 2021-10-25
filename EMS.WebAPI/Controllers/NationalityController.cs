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
    public class NationalityController : BaseController
    {
        private readonly INationalityService _Service;

        public NationalityController(INationalityService service)
        {
            _Service = service;
        }

        [HttpGet("{ID}")]
        public IActionResult GetNationalityByID(Guid ID)
        {
            var Result = _Service.GetNationalityByID(ID);
            return Ok(Result);
        }

        [HttpGet]
        public IActionResult GetAllNationalitys()
        {
            var Result = _Service.GetAllNationalitys();
            return Ok(Result);
        }

        [HttpPost]
        public IActionResult AddNationality(NationalityDTO NationalityDTO)
        {
            var Result = _Service.AddNationality(NationalityDTO, out Message);
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
        public IActionResult UpdateNationality(NationalityDTO NationalityDTO)
        {
            var Result = _Service.UpdateNationality(NationalityDTO, out Message);
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
        public IActionResult DeleteNationality(Guid ID)
        {
            var Result = _Service.DeleteNationality(ID, out Message);
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

