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
    public class TeachersController : ControllerBase
    {
        private ITeacherService _teacherService;
        private ITeacherSchoolsService _teacherSchoolsService;
        private ITeachersWithSchoolsService _teachersWithSchoolsService;
        private ITeacherSudentsService _teacherSudentsService;
        public TeachersController(ITeacherService teacherService, 
            ITeacherSchoolsService teacherSchoolsService, 
            ITeachersWithSchoolsService teachersWithSchoolsService,
            ITeacherSudentsService teacherSudentsService)
        {
            _teacherService = teacherService;
            _teacherSchoolsService = teacherSchoolsService;
            _teachersWithSchoolsService = teachersWithSchoolsService;
            _teacherSudentsService = teacherSudentsService;
        }
        [HttpGet(template: "GetTeachers")]
        public IActionResult GetList([FromQuery] int? id)
        {
            if (id != null)
            {
                int _id = Convert.ToInt32(id);
                var data = _teacherService.Get(_id);
                if (data.Success)
                {
                    return Ok(data);
                }
                return BadRequest(data.Message);
            }
            else
            {
                var data = _teacherService.GetList();
                if (data.Success)
                {
                    return Ok(data);
                }
                return BadRequest(data.Message);
            }
        }
        [HttpPost(template: "AddTeacherToSchool")]
        public IActionResult AddTeacherToSchool([FromBody] TeacherSchools teacherSchools)
        {
            var data = _teacherSchoolsService.Add(teacherSchools);
            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }
        [HttpGet(template: "GetTeachersWithSchools")]
        public IActionResult GetTeachersWithSchools([FromQuery] int? id)
        {
            var data = _teachersWithSchoolsService.GetTeachersWithSchoolsForApi(id);
            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }
        [HttpGet(template: "GetTeacherStudents")]
        public IActionResult GetTeacherStudents([FromQuery] int teacherId)
        {
            var data = _teacherSudentsService.GetList(teacherId);
            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }
    }
}