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
    public class EFTeacherSudentsDal : ITeacherSudentsDal
    {
        SchoolContext _context;
        public EFTeacherSudentsDal(SchoolContext context)
        {
            _context = context;
        }

        public List<Student> GetTeacherSudents(int? teacherId)
        {
            return _context.TeacherSudents.FromSql("SpGetTeacherWithStudents {0}", teacherId).ToList();
        }
    }
}
