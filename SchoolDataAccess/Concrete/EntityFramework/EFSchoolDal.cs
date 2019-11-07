using SchoolCore.DataAccess.EntityFramework;
using SchoolDataAccess.Abstract;
using SchoolDataAccess.Concrete.EntityFramework.Contexts;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SchoolDataAccess.Concrete.EntityFramework
{
    public class EFSchoolDal : EfEntityRepositoryBase<School, SchoolContext>, ISchoolDal
    {
     
    }
}
