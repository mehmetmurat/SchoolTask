using SchoolCore.Utilities.Results;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolBusiness.Abstract
{
    public interface ITeacherSchoolsService
    {
        IDataResult<List<TeacherSchools>> GetList();
        IResult Add(TeacherSchools teacherSchools);
        IResult Delete(TeacherSchools teacherSchools);
        IResult Update(TeacherSchools teacherSchools);
    }
}
