﻿using Autofac;
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

            builder.RegisterType<TeacherService>().As<ITeacherService>();
            builder.RegisterType<EFTeacherDal>().As<ITeacherDal>();

            builder.RegisterType<TeacherSchoolsService>().As<ITeacherSchoolsService>();
            builder.RegisterType<EFTeacherSchoolsDal>().As<ITeacherSchoolsDal>();

            builder.RegisterType<StudentTeachersService>().As<IStudentTeachersService>();
            builder.RegisterType<EFStudentTeachersDal>().As<IStudentTeachersDal>();

            builder.RegisterType<TeachersWithSchoolsService>().As<ITeachersWithSchoolsService>();
            builder.RegisterType<EFTeachersWithSchoolsDal>().As<ITeachersWithSchoolsDal>();

            builder.RegisterType<TeacherSudentsService>().As<ITeacherSudentsService>();
            builder.RegisterType<EFTeacherSudentsDal>().As<ITeacherSudentsDal>();

            builder.RegisterType<SchoolContext>().AsSelf().As<DbContext>().InstancePerLifetimeScope();
        }
    }
}
