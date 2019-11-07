using SchoolBusiness.Abstract;
using SchoolCore.Utilities.Results;
using SchoolDataAccess.Abstract;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolBusiness.Concrete
{
    public class SchoolService : ISchoolService
    {

        private ISchoolDal _ISchoolDal;
        public SchoolService(ISchoolDal schoolDal)
        {
            _ISchoolDal = schoolDal;
        }

        public IResult Add(School school)
        {
            _ISchoolDal.Add(school);
            return new SuccessResult(message: Contants.Messages.AddMessage);
        }

        public IResult Delete(School school)
        {
            _ISchoolDal.Delete(school);
            return new SuccessResult(message: Contants.Messages.DeleteMessage);
        }

        public IDataResult<School> Get(int schoolId)
        {
            return new SuccessDataResult<School>(_ISchoolDal.Get(filter: x => x.SchoolId == schoolId));
        }

        public IDataResult<List<School>> GetList()
        {
            return new SuccessDataResult<List<School>>(_ISchoolDal.GetList().ToList());
        }

        public IDataResult<List<School>> GetListByTeacher(int teacherId)
        {
            return new SuccessDataResult<List<School>>(_ISchoolDal.GetList(filter:x => x.SchoolId == teacherId).ToList());
        }

        public IResult Update(School school)
        {
            _ISchoolDal.Update(school);
            return new SuccessResult(message: Contants.Messages.UpdateMessage); 
        }

    }
}
