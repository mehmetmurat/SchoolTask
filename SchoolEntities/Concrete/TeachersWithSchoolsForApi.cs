using SchoolCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolEntities.Concrete
{
    public class TeachersWithSchoolsForApi : IEntity
    {
        [Key]
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long TcIdentityNumber { get; set; }
        public List<School> Schools {get; set;}      
    }
}
