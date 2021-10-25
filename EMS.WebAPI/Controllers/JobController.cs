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
    public class JobController : BaseController
    {
        private readonly IJobService _Service;

        public JobController(IJobService service)
        {
            _Service = service;
        }

        [HttpGet("{ID}")]
        public IActionResult GetJobByID(Guid ID)
        {
            var Result = _Service.GetJobByID(ID);
            return Ok(Result);
        }

        [HttpGet]
        public IActionResult GetAllJobs()
        {
            var Result = _Service.GetAllJobs();
            return Ok(Result);
        }

        [HttpPost]
        public IActionResult AddJob(JobDTO JobDTO)
        {
            var Result = _Service.AddJob(JobDTO, out Message);
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
        public IActionResult UpdateJob(JobDTO JobDTO)
        {
            var Result = _Service.UpdateJob(JobDTO, out Message);
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
        public IActionResult DeleteJob(Guid ID)
        {
            var Result = _Service.DeleteJob(ID, out Message);
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

