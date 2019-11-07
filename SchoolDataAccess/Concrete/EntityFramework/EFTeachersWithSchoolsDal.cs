using Microsoft.EntityFrameworkCore;
using SchoolDataAccess.Abstract;
using SchoolDataAccess.Concrete.EntityFramework.Contexts;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataAccess.Concrete.EntityFramework
{
    public class EFTeachersWithSchoolsDal : ITeachersWithSchoolsDal
    {
        SchoolContext _context;
        public EFTeachersWithSchoolsDal(SchoolContext context)
        {
            _context = context;
        }

        public List<TeachersWithSchools> GetSchoolTeachers(int? teacherId)
        {

            return  _context.TeachersWithSchools.FromSql("SpGetTeacherWtihSchools {0}", teacherId).ToList();
        }

    }
}
