﻿using SchoolCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolEntities.Concrete
{
    public class TeacherSchools : IEntity
    {
        
        [Key]
        public int Id { get; set; }
        public int TeacherId { get; set; }
       
        public int SchoolId { get; set; }

    }
}
