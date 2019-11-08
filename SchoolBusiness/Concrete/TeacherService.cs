using SchoolBusiness.Abstract;
using SchoolCore.Utilities.Results;
using SchoolDataAccess.Abstract;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolBusiness.Concrete
{
    public class TeacherService : ITeacherService
    {

        private ITeacherDal _ITeacherDal;
        public TeacherService(ITeacherDal teacherDal)
        {
            _ITeacherDal = teacherDal;
        }

        public IResult Add(Teacher teacher)
        {          
            try
            {
                _ITeacherDal.Add(teacher);
                return new SuccessResult(message: Contants.Messages.AddMessage);
            }
            catch (Exception ex)
            {
                return new ErrorResult(message: ex.Message);
            }
        }

        public IResult Delete(Teacher teacher)
        {            
            try
            {
                _ITeacherDal.Delete(teacher);
                return new SuccessResult(message: Contants.Messages.DeleteMessage);
            }
            catch (Exception ex)
            {
                return new ErrorResult(message: ex.Message);
            }
        }

        public IDataResult<Teacher> Get(int teacherId)
        {
            return new SuccessDataResult<Teacher>(_ITeacherDal.Get(filter: x => x.TeacherId == teacherId));
        }

        public IDataResult<List<Teacher>> GetList()
        {
            return new SuccessDataResult<List<Teacher>>(_ITeacherDal.GetList().ToList());
        }
        public IResult Update(Teacher teacher)
        {
            try
            {
                _ITeacherDal.Update(teacher);
                return new SuccessResult(message: Contants.Messages.UpdateMessage);
            }
            catch (Exception ex)
            {
                return new ErrorResult(message: ex.Message);
            }
        }

    }
}
