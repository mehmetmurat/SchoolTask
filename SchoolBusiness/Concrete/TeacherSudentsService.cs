using SchoolBusiness.Abstract;
using SchoolCore.Utilities.Results;
using SchoolDataAccess.Abstract;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolBusiness.Concrete
{
    public class TeacherSudentsService : ITeacherSudentsService
    {
        private ITeacherSudentsDal _ITeacherSudentsDal;
        public TeacherSudentsService(ITeacherSudentsDal teacherSudentsDal)
        {
            _ITeacherSudentsDal = teacherSudentsDal;
        }

        public IDataResult<List<Student>> GetList(int? teacherId)
        {
            return new SuccessDataResult<List<Student>>(_ITeacherSudentsDal.GetTeacherSudents(teacherId));
        }
    }
}
