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
    public class UserAttendController : BaseController
    {
        private readonly IUserAttendService _Service;

        public UserAttendController(IUserAttendService service)
        {
            _Service = service;
        }

        [HttpGet("{ID}")]
        public IActionResult GetUserAttendByID(Guid ID)
        {
            var Result = _Service.GetUserAttendByID(ID);
            return Ok(Result);
        }

        [HttpGet]
        public IActionResult GetAllUserAttends()
        {
            var Result = _Service.GetAllUserAttends();
            return Ok(Result);
        }

        [HttpPost]
        public IActionResult AddUserAttend(UserAttendDTO UserAttendDTO)
        {
            var Result = _Service.AddUserAttend(UserAttendDTO, out Message);
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
        public IActionResult UpdateUserAttend(UserAttendDTO UserAttendDTO)
        {
            var Result = _Service.UpdateUserAttend(UserAttendDTO, out Message);
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
        public IActionResult DeleteUserAttend(Guid ID)
        {
            var Result = _Service.DeleteUserAttend(ID, out Message);
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

