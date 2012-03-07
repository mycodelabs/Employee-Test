using System.Collections.Generic;
using System.Linq;
using controllers.home.contracts;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using domain;
using Machine.Specifications;
using tasks;
using tasks.contracts;
using tests.utilities;

namespace tests.tasks
{
    [Subject("Employee Tasks Specs")]
    public class employee_tasks_spec
    {
        public abstract class employee_tasks_concern : Observes<IEmployeeTasks, EmployeeTasks>
        {
        }

        

        public class when_employee_tasks_is_asked_to_return_all_employees : employee_tasks_concern
        {
            private static IList<Employee> result;
            private static IList<Employee> the_employees;
            private static IEmployeeRepository the_employee_repository;

            private Establish c = () =>
                                      {
                                           the_employees = the_employees.create_instance(); 
                                           the_employee_repository = depends.on<IEmployeeRepository>();
                                           the_employee_repository.setup(x => x.GetAll()).Return(the_employees);
                                      };

            private Because b = () => result = sut.GetAll();
            private It should_return_all_employees = () => result.Count().ShouldEqual(1);
        }
    }
}
