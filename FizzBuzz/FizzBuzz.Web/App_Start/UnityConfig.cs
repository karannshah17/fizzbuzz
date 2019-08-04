using FizzBuzz.Business.BusinessClasses;
using FizzBuzz.Business.Core;
using FizzBuzz.Web.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace FizzBuzz.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IDateTimeProvider, DateProvider>();

            container.RegisterType<INumberModuloCheck, NumberModuloByThreeCheck>("NumberModuloByThree");
            container.RegisterType<INumberModuloCheck, NumberModuloByFiveCheck>("NumberModuloByFive");
            container.RegisterType<INumberModuloCheck, NumberModuloByFifteenCheck>("NumberModuloByFifteen");
            container.RegisterType<INumberModuloCheck, DefaultModuloCheck>("NumericString");


            container.RegisterType<IOutputStringService, OutputStringService>(
     new InjectionConstructor(
         new ResolvedArrayParameter<INumberModuloCheck>(
             new ResolvedParameter<INumberModuloCheck>("NumberModuloByFifteen"),
             new ResolvedParameter<INumberModuloCheck>("NumberModuloByFive"),
             new ResolvedParameter<INumberModuloCheck>("NumberModuloByThree"),
           new ResolvedParameter<INumberModuloCheck>("NumericString")
       )
     ));
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}