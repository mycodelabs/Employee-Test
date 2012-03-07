using System;
using controllers.home.contracts;
using controllers.home.mappers;
using controllers.home.mappers.contracts;
using infrastructure;
using Ninject;
using Ninject.Modules;
using tasks;
using tasks.contracts;

namespace presentation
{
    public class NinjectContainer : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IEmployeeTasks>().To<EmployeeTasks>();
            Kernel.Bind<IEmployeeRepository>().To<EmployeeRepository>();
            Kernel.Bind<IEmployeePageViewModelMapper>().To<EmployeePageViewModelMapper>();
        }
    }
}