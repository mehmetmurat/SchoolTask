using SchoolBusiness.Abstract;
using SchoolCore.Utilities.Results;
using SchoolDataAccess.Abstract;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolBusiness.Concrete
{
    public class StudentTeachersService : IStudentTeachersService
    {

        private IStudentTeachersDal _IStudentTeachersDal;
        public StudentTeachersService(IStudentTeachersDal studentTeachersDal)
        {
            _IStudentTeachersDal = studentTeachersDal;
        }

        public IResult Add(StudentTeachers studentTeacher)
        {
            _IStudentTeachersDal.Add(studentTeacher);
            return new SuccessResult(message: Contants.Messages.AddMessage);
        }

        public IResult Delete(StudentTeachers studentTeacher)
        {
            _IStudentTeachersDal.Delete(studentTeacher);
            return new SuccessResult(message: Contants.Messages.DeleteMessage);
        }
        public IDataResult<List<StudentTeachers>> GetList()
        {
            return new SuccessDataResult<List<StudentTeachers>>(_IStudentTeachersDal.GetList().ToList());
        }
        public IResult Update(StudentTeachers studentTeacher)
        {
            _IStudentTeachersDal.Update(studentTeacher);
            return new SuccessResult(message: Contants.Messages.UpdateMessage); 
        }

    }
}
