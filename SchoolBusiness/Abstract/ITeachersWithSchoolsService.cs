using SchoolCore.Utilities.Results;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolBusiness.Abstract
{
    public interface ITeachersWithSchoolsService
    {
        IDataResult<List<TeachersWithSchools>> GetList(int? teacherId);
        IDataResult<List<TeachersWithSchoolsForApi>> GetTeachersWithSchoolsForApi(int? teacherId);
    }
}
