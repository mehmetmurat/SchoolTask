using SchoolCore.Utilities.Results;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolBusiness.Abstract
{
    public interface IStudentService
    {
        IDataResult<Student> Get(int studentId);
        IDataResult<List<Student>> GetList();
        IResult Add(Student student);
        IResult Delete(Student student);
        IResult Update(Student student);
    }
}
