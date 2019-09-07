// <copyright file="UnityConfig.cs" company="Fizz Buzz">
// Copyright (c) Fizz Buzz. All rights reserved.
// </copyright>

namespace FizzBuzz.Web
{
    using System.Web.Mvc;
    using FizzBuzz.Business.BusinessClasses;
    using FizzBuzz.Business.Core;
    using FizzBuzz.Web.Repository;
    using Unity;
    using Unity.Injection;
    using Unity.Mvc5;

    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IExceptionalDayCheck, ExceptionalDayCheck>();

            container.RegisterType<INumberModuloCheck, NumberModuloByThreeCheck>("NumberModuloByThree");
            container.RegisterType<INumberModuloCheck, NumberModuloByFiveCheck>("NumberModuloByFive");
            container.RegisterType<INumberModuloCheck, NumberModuloByFifteenCheck>("NumberModuloByFifteen");
            container.RegisterType<INumberModuloCheck, DefaultModuloCheck>("NumericString");

            container.RegisterType<IMessageService, MessageService>(
     new InjectionConstructor(
         new ResolvedArrayParameter<INumberModuloCheck>(
             new ResolvedParameter<INumberModuloCheck>("NumberModuloByFifteen"),
             new ResolvedParameter<INumberModuloCheck>("NumberModuloByFive"),
             new ResolvedParameter<INumberModuloCheck>("NumberModuloByThree"),
             new ResolvedParameter<INumberModuloCheck>("NumericString"))));
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}