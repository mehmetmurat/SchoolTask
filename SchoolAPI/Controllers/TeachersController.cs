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
    public class TeachersController : ControllerBase
    {
        private ITeachersWithSchoolsService _teachersWithSchoolsService;
        public TeachersController(ITeachersWithSchoolsService teachersWithSchoolsService)
        {
            _teachersWithSchoolsService = teachersWithSchoolsService;
        }

        [HttpGet(template: "GetTeachersWithSchools")]
        public IActionResult GetList()
        {
            var data = _teachersWithSchoolsService.GetList(null);
            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);

        }
    }
}