using SchoolBusiness.Abstract;
using SchoolCore.Utilities.Results;
using SchoolDataAccess.Abstract;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IDataResult<List<TeachersWithSchoolsForApi>> GetTeachersWithSchoolsForApi(int? teacherId)
        {
            return new SuccessDataResult<List<TeachersWithSchoolsForApi>>(FormatDateForJson(teacherId));
        }
        private List<TeachersWithSchoolsForApi> FormatDateForJson(int? teacherId)
        {
            List<TeachersWithSchoolsForApi> data = new List<TeachersWithSchoolsForApi>();
         
            var rawData = _ITeachersWithSchoolsDal.GetSchoolTeachers(teacherId);

            int tescherId = 0;
            foreach (var item in rawData)
            {
                var teachersWithSchoolsForApi = new TeachersWithSchoolsForApi();
                if (tescherId != item.TeacherId)
                {                   
                    teachersWithSchoolsForApi.Name = item.Name;
                    teachersWithSchoolsForApi.Surname = item.Surname;
                    teachersWithSchoolsForApi.TcIdentityNumber = item.TcIdentityNumber;
                    tescherId = item.TeacherId;
                    var schoolsData = rawData.Where(x =>x.TeacherId == tescherId);
                    var schools = new List<School>();
                    foreach (var tchItem in schoolsData)
                    {
                        var school = new School();
                        school.SchoolId = Convert.ToInt32(tchItem.SchoolId);
                        school.SchoolName = tchItem.SchoolName;
                        school.Address = tchItem.Address;
                        school.City = tchItem.City;
                        school.District = tchItem.District;
                        schools.Add(school);
                    }
                    teachersWithSchoolsForApi.Schools = schools;
                    data.Add(teachersWithSchoolsForApi);
                }
            }
            return data;
        }
    }
}
