using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataAccess.Abstract
{
    public interface ITeachersWithSchoolsDal
    {
       List<TeachersWithSchools> GetSchoolTeachers(int? teacherId);
    }
}
