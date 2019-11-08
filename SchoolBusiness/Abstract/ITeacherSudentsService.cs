using SchoolCore.Utilities.Results;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolBusiness.Abstract
{
    public interface ITeacherSudentsService
    {
        IDataResult<List<Student>> GetList(int? teacherId);
    }
}
