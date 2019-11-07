using SchoolCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolEntities.Concrete
{
    public class School : IEntity
    {
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
    }
}
