using System;
using DynamicForms.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace DynamicForms
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            //register dependencies for DI
            //AppContainer.RegisterDependencies();

            //initial viewmodel to be loaded
            RegisterAppStart<DynamicPageViewModel>();
        }
    }
}
