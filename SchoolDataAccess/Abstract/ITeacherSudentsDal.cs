using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataAccess.Abstract
{
    public interface ITeacherSudentsDal
    {
       List<Student> GetTeacherSudents(int? teacherId);
    }
}
