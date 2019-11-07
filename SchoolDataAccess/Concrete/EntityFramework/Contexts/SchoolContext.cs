using Microsoft.EntityFrameworkCore;
using SchoolEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataAccess.Concrete.EntityFramework.Contexts
{
    public class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=78.142.210.2\MSSQLSERVER2012;Database=School;User Id=School82;Password=i0f16Zt_;");
        }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public virtual DbSet<TeachersWithSchools> TeachersWithSchools { get; set; }
    }
}
