using SchoolCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolEntities.Concrete
{
    public class Student : IEntity
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long TcIdentityNumber { get; set; }
        public int SchoolId { get; set; }
    }
}
