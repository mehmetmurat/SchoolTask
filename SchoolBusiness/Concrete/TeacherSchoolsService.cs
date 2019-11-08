using SchoolBusiness.Abstract;
using SchoolCore.Utilities.Results;
using SchoolDataAccess.Abstract;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolBusiness.Concrete
{
    public class TeacherSchoolsService : ITeacherSchoolsService
    {

        private ITeacherSchoolsDal _ITeacherSchoolsDal;
        public TeacherSchoolsService(ITeacherSchoolsDal teacherSchoolsDal)
        {
            _ITeacherSchoolsDal = teacherSchoolsDal;
        }

        public IResult Add(TeacherSchools teacherSchools)
        {            
            try
            {
                _ITeacherSchoolsDal.Add(teacherSchools);
                return new SuccessResult(message: Contants.Messages.AddMessage);
            }
            catch (Exception ex)
            {
                return new ErrorResult(message: ex.Message);
            }
        }

        public IResult Delete(TeacherSchools teacherSchools)
        {            
            try
            {
                _ITeacherSchoolsDal.Delete(teacherSchools);
                return new SuccessResult(message: Contants.Messages.DeleteMessage);
            }
            catch (Exception ex)
            {
                return new ErrorResult(message: ex.Message);
            }
        }
        public IDataResult<List<TeacherSchools>> GetList()
        {
            return new SuccessDataResult<List<TeacherSchools>>(_ITeacherSchoolsDal.GetList().ToList());
        }
        public IResult Update(TeacherSchools teacherSchools)
        {       
            try
            {
                _ITeacherSchoolsDal.Update(teacherSchools);
                return new SuccessResult(message: Contants.Messages.UpdateMessage);
            }
            catch (Exception ex)
            {
                return new ErrorResult(message: ex.Message);
            }
        }

    }
}
