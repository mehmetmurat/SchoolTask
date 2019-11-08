using SchoolCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolEntities.Concrete
{
    public class TeachersWithSchools: IEntity
    {
        [Key]
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long TcIdentityNumber { get; set; }      
        public int? SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
    }
}
