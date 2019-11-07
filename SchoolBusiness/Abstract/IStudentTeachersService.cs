using SchoolCore.Utilities.Results;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolBusiness.Abstract
{
    public interface IStudentTeachersService
    {
        IDataResult<List<StudentTeachers>> GetList();
        IResult Add(StudentTeachers studentTeachers);
        IResult Delete(StudentTeachers studentTeachers);
        IResult Update(StudentTeachers studentTeachers);
    }
}
