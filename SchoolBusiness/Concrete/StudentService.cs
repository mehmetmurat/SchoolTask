using SchoolBusiness.Abstract;
using SchoolCore.Utilities.Results;
using SchoolDataAccess.Abstract;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolBusiness.Concrete
{
    public class StudentService : IStudentService
    {

        private IStudentDal _IStudentDal;
        public StudentService(IStudentDal studentDal)
        {
            _IStudentDal = studentDal;
        }

        public IResult Add(Student student)
        {
            _IStudentDal.Add(student);
            return new SuccessResult(message: Contants.Messages.AddMessage);
        }

        public IResult Delete(Student student)
        {
            _IStudentDal.Delete(student);
            return new SuccessResult(message: Contants.Messages.DeleteMessage);
        }

        public IDataResult<Student> Get(int studentId)
        {
            return new SuccessDataResult<Student>(_IStudentDal.Get(filter: x => x.StudentId == studentId));
        }

        public IDataResult<List<Student>> GetList()
        {
            return new SuccessDataResult<List<Student>>(_IStudentDal.GetList().ToList());
        }     

        public IResult Update(Student student)
        {
            _IStudentDal.Update(student);
            return new SuccessResult(message: Contants.Messages.UpdateMessage); 
        }

    }
}
