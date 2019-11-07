using SchoolCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolEntities.Concrete
{
    public  class StudentTeachers: IEntity
    {      
        public int StudentId { get; set; }
        public int TeacherId { get; set; }

    }
}
