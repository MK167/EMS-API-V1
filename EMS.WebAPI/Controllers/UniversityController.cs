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
    public class UniversityController : BaseController
    {
        private readonly IUniversityService _Service;

        public UniversityController(IUniversityService service)
        {
            _Service = service;
        }

        [HttpGet("{ID}")]
        public IActionResult GetUniversityByID(Guid ID)
        {
            var Result = _Service.GetUniversityByID(ID);
            return Ok(Result);
        }

        [HttpGet]
        public IActionResult GetAllUniversitys()
        {
            var Result = _Service.GetAllUniversitys();
            return Ok(Result);
        }

        [HttpPost]
        public IActionResult AddUniversity(UniversityDTO UniversityDTO)
        {
            var Result = _Service.AddUniversity(UniversityDTO, out Message);
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
        public IActionResult UpdateUniversity(UniversityDTO UniversityDTO)
        {
            var Result = _Service.UpdateUniversity(UniversityDTO, out Message);
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
        public IActionResult DeleteUniversity(Guid ID)
        {
            var Result = _Service.DeleteUniversity(ID, out Message);
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


