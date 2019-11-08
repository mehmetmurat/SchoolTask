using SchoolCore.Utilities.Results;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolBusiness.Abstract
{
    public interface ISchoolService
    {
        IDataResult<School> Get(int schoolId);
        IDataResult<List<School>> GetList();
        IResult Add(School school);
        IResult Delete(School school);
        IResult Update(School school);
        IResult UpdateWithExcludeProperty(School school, string[] excludePropertyNames);
    }
}
