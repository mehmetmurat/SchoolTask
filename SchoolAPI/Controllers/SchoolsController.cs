using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolBusiness.Abstract;
using SchoolEntities.Concrete;

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
        public IActionResult GetList([FromQuery] int? id)
        {
            if (id != null)
            {
                int _id = Convert.ToInt32(id);
                var data = _schoolService.Get(_id);
                if (data.Success)
                {
                    return Ok(data);
                }
                return BadRequest(data.Message);
            }
            else
            {
                var data = _schoolService.GetList();
                if (data.Success)
                {
                    return Ok(data);
                }
                return BadRequest(data.Message);
            }
        }
        [HttpPost(template: "InsertSchool")]
        public IActionResult InsertSchool([FromBody] School school)
        {
            var data = _schoolService.Add(school);
            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }
        [HttpPost(template: "UpdateSchool")]
        public IActionResult UpdateSchool([FromBody] School school)
        {
            string [] excludeProperty = new string[] { "SchoolName" };
            var data = _schoolService.UpdateWithExcludeProperty(school, excludeProperty);
            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }
        [HttpPost(template: "DeleteSchool")]
        public IActionResult DeleteSchool([FromBody] School school)
        {
            string[] excludeProperty = new string[] { "SchoolName" };
            var data = _schoolService.Delete(school);
            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }


    }
}