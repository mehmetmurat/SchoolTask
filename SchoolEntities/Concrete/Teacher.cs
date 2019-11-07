using SchoolCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolEntities.Concrete
{
    public class Teacher : IEntity
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long TcIdentityNumber { get; set; }
    }
}
