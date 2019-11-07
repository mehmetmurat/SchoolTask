using SchoolBusiness.Abstract;
using SchoolCore.Utilities.Results;
using SchoolDataAccess.Abstract;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolBusiness.Concrete
{
    public class TeachersWithSchoolsService : ITeachersWithSchoolsService
    {
        private ITeachersWithSchoolsDal _ITeachersWithSchoolsDal;
        public TeachersWithSchoolsService(ITeachersWithSchoolsDal teachersWithSchool)
        {
            _ITeachersWithSchoolsDal = teachersWithSchool;
        }
        public IDataResult<List<SchoolEntities.Concrete.TeachersWithSchools>> GetList(int? teacherId)
        {
            return new SuccessDataResult<List<SchoolEntities.Concrete.TeachersWithSchools>>(_ITeachersWithSchoolsDal.GetSchoolTeachers(teacherId));
        }
    }
}
