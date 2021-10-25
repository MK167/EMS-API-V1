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
    public class UserTypeController : BaseController
    {
        private readonly IUserTypeService _Service;

        public UserTypeController(IUserTypeService service)
        {
            _Service = service;
        }

        [HttpGet("{ID}")]
        public IActionResult GetUserTypeByID(Guid ID)
        {
            var Result = _Service.GetUserTypeByID(ID);
            return Ok(Result);
        }

        [HttpGet]
        public IActionResult GetAllUserTypes()
        {
            var Result = _Service.GetAllUserTypes();
            return Ok(Result);
        }

        [HttpPost]
        public IActionResult AddUserType(UserTypeDTO UserTypeDTO)
        {
            var Result = _Service.AddUserType(UserTypeDTO, out Message);
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
        public IActionResult UpdateUserType(UserTypeDTO UserTypeDTO)
        {
            var Result = _Service.UpdateUserType(UserTypeDTO, out Message);
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
        public IActionResult DeleteUserType(Guid ID)
        {
            var Result = _Service.DeleteUserType(ID, out Message);
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

