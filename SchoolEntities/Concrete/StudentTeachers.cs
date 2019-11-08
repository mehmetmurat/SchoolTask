using SchoolCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolEntities.Concrete
{
    public  class StudentTeachers: IEntity
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }

    }
}
