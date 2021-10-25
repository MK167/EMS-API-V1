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
    public class UserAdminController : BaseController
    {
        private readonly IUserAdminService _Service;

        public UserAdminController(IUserAdminService service)
        {
            _Service = service;
        }

        [HttpGet("{ID}")]
        public IActionResult GetUserAdminByID(Guid ID)
        {
            var Result = _Service.GetUserAdminByID(ID);
            return Ok(Result);
        }

        [HttpGet]
        public IActionResult GetAllUserAdmins()
        {
            var Result = _Service.GetAllUserAdmins();
            return Ok(Result);
        }

        [HttpPost]
        public IActionResult AddUserAdmin(UserAdminDTO UserAdminDTO)
        {
            var Result = _Service.AddUserAdmin(UserAdminDTO, out Message);
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
        public IActionResult UpdateUserAdmin(UserAdminDTO UserAdminDTO)
        {
            var Result = _Service.UpdateUserAdmin(UserAdminDTO, out Message);
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
        public IActionResult DeleteUserAdmin(Guid ID)
        {
            var Result = _Service.DeleteUserAdmin(ID, out Message);
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


