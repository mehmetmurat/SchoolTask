using Autofac;
using Autofac.Core;
using Microsoft.EntityFrameworkCore;
using SchoolBusiness.Abstract;
using SchoolBusiness.Concrete;
using SchoolDataAccess.Abstract;
using SchoolDataAccess.Concrete.EntityFramework;
using SchoolDataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolBusiness.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModul : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SchoolService>().As<ISchoolService>();
            builder.RegisterType<EFSchoolDal>().As<ISchoolDal>();

            builder.RegisterType<StudentService>().As<IStudentService>();
            builder.RegisterType<EFStudentDal>().As<IStudentDal>();

            builder.RegisterType<TeachersWithSchoolsService>().As<ITeachersWithSchoolsService>();
            builder.RegisterType<EFTeachersWithSchoolsDal>().As<ITeachersWithSchoolsDal>();

            builder.RegisterType<SchoolContext>().AsSelf().As<DbContext>().InstancePerLifetimeScope();
        }
    }
}
