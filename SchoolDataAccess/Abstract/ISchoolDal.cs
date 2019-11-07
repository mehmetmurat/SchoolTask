using SchoolCore.DataAccess;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataAccess.Abstract
{
    public interface ISchoolDal: IEntityRepository<School>
    {
    }
}

