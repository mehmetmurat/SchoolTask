using SchoolCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolEntities.Concrete
{
    public class TeacherSchools : IEntity
    {
        public int TeacherId { get; set; }
        public int SchoolId { get; set; }

    }
}
