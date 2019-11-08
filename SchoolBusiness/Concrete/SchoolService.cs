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
            try
            {
                _ISchoolDal.Add(school);
                return new SuccessResult(message: Contants.Messages.AddMessage);
            }
            catch (Exception ex)
            {
                return new ErrorResult(message: ex.Message);
            }
            
        }

        public IResult Delete(School school)
        {
            try
            {
                _ISchoolDal.Delete(school);
                return new SuccessResult(message: Contants.Messages.DeleteMessage);
            }
            catch (Exception ex)
            {
                return new ErrorResult(message: ex.Message);
            }          
        }

        public IDataResult<School> Get(int schoolId)
        {
            return new SuccessDataResult<School>(_ISchoolDal.Get(filter: x => x.SchoolId == schoolId));
        }

        public IDataResult<List<School>> GetList()
        {
            return new SuccessDataResult<List<School>>(_ISchoolDal.GetList().ToList());
        }

        public IResult Update(School school)
        {            
            try
            {
                _ISchoolDal.Update(school);
                return new SuccessResult(message: Contants.Messages.UpdateMessage);
            }
            catch (Exception ex)
            {
                return new ErrorResult(message: ex.Message);
            }
        }

        public IResult UpdateWithExcludeProperty(School school, string[] excludePropertyNames)
        {
            try
            {
                _ISchoolDal.UpdateWithExcludeProperty(school, excludePropertyNames);
                return new SuccessResult(message: Contants.Messages.UpdateMessage);
            }
            catch (Exception ex)
            {
                return new ErrorResult(message: ex.Message);
            }
        }
    }
}
