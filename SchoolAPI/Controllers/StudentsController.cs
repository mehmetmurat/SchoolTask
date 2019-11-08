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
    public class StudentsController : ControllerBase
    {
        private IStudentService _studentService;
        private IStudentTeachersService _studentTeachersService;
        public StudentsController(IStudentService studentService, IStudentTeachersService studentTeachersService)
        {
            _studentService = studentService;
            _studentTeachersService = studentTeachersService;
        }
        [HttpGet(template: "GetStudents")]
        public IActionResult GetStudents([FromQuery] int? id)
        {
            if (id != null)
            {
                int _id = Convert.ToInt32(id);
                var data = _studentService.Get(_id);
                if (data.Success)
                {
                    return Ok(data);
                }
                return BadRequest(data.Message);
            }
            else
            {
                var data = _studentService.GetList();
                if (data.Success)
                {
                    return Ok(data);
                }
                return BadRequest(data.Message);
            }
        }
        [HttpGet(template: "GetStudentsBySchoolId")]
        public IActionResult GetStudentsBySchoolId([FromQuery] int schoolId)
        {                           
                var data = _studentService.GetBySchoolId(schoolId);
                if (data.Success)
                {
                    return Ok(data);
                }
                return BadRequest(data.Message);           
        }
        [HttpPost(template: "InsertStudent")]
        public IActionResult InsertSchool([FromBody] Student student)
        {
            var data = _studentService.Add(student);
            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }
        [HttpPost(template: "AddTeacherToSchool")]
        public IActionResult AddTeacherToSchool([FromBody] StudentTeachers studentTeachers)
        {
            var data = _studentTeachersService.Add(studentTeachers);
            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }


    }
}