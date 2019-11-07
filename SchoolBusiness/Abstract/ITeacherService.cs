using SchoolCore.Utilities.Results;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolBusiness.Abstract
{
    public interface ITeacherService
    {
        IDataResult<Teacher> Get(int teacherId);
        IDataResult<List<Teacher>> GetList();
        IResult Add(Teacher teacher);
        IResult Delete(Teacher teacher);
        IResult Update(Teacher teacher);
    }
}
