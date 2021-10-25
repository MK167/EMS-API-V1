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
    public class UserImageController : BaseController
    {
        private readonly IUserImageService _Service;

        public UserImageController(IUserImageService service)
        {
            _Service = service;
        }

        [HttpGet("{ID}")]
        public IActionResult GetUserImageByID(Guid ID)
        {
            var Result = _Service.GetUserImageByID(ID);
            return Ok(Result);
        }

        [HttpGet]
        public IActionResult GetAllUserImages()
        {
            var Result = _Service.GetAllUserImages();
            return Ok(Result);
        }

        [HttpPost]
        public IActionResult AddUserImage(UserImageDTO UserImageDTO)
        {
            var Result = _Service.AddUserImage(UserImageDTO, out Message);
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
        public IActionResult UpdateUserImage(UserImageDTO UserImageDTO)
        {
            var Result = _Service.UpdateUserImage(UserImageDTO, out Message);
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
        public IActionResult DeleteUserImage(Guid ID)
        {
            var Result = _Service.DeleteUserImage(ID, out Message);
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


