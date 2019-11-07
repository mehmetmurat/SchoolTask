using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolBusiness.Abstract;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        private ISchoolService _schoolService;
        public SchoolsController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }
        [HttpGet(template: "GetSchools")]
        public IActionResult GetList()
        {
            var data = _schoolService.GetList();
            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
          
        }
    }
}