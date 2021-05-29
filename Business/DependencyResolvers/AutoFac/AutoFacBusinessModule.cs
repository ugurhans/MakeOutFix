using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrate;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrate.EntitiyFrameWork;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DietManager>().As<IDietService>().SingleInstance();
            builder.RegisterType<EfDietDal>().As<IDietDal>().SingleInstance();


            builder.RegisterType<DietMethodManager>().As<IDietMethodService>().SingleInstance();
            builder.RegisterType<EfDietMethodDal>().As<IDietMethodDal>().SingleInstance();


            builder.RegisterType<DayManager>().As<IDayService>().SingleInstance();
            builder.RegisterType<EfDayDal>().As<IDayDal>().SingleInstance();


            builder.RegisterType<IllnessManager>().As<IIllnessService>().SingleInstance();
            builder.RegisterType<EfIllnessDal>().As<IIllnessDal>().SingleInstance();


            builder.RegisterType<PatientManager>().As<IPatientService>().SingleInstance();
            builder.RegisterType<EfPatientDal>().As<IPatientDal>().SingleInstance();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
