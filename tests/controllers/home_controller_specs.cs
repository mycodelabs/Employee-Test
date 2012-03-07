using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using controllers.home.contracts;
using controllers.home.mappers.contracts;
using controllers.home.viewmodels;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using domain;
using Machine.Specifications;
using presentation.Controllers;
using tests.utilities;

namespace tests
{
    [Subject("Home Controller")]
    public class home_controller_specs
    {
        public abstract class when_home_controller_is_asked_to_get_employess_concern : Observes<HomeController>
        {
        }

        public class when_home_controller_is_asked_to_return_view : when_home_controller_is_asked_to_get_employess_concern
        {
            private static ActionResult result;

            private static IList<Employee> the_employees;

            private static IEmployeeTasks the_employee_tasks;

            private Establish c = () =>
                                      {
                                          the_employees = the_employees.create_instance();
                                          the_employee_tasks = depends.on<IEmployeeTasks>();
                                          the_page_view_model = new EmployeePageViewModel
                                                                    {SummaryEmployeeViewModels = the_employee_summary_view_model.create_instance()};
                                          the_employee_tasks.setup(x => x.GetAll()).Return(the_employees);
                                          the_page_view_model_mapper = depends.on<IEmployeePageViewModelMapper>();
                                          the_page_view_model_mapper.setup(x => x.MapFrom(the_employees)).Return(the_page_view_model);
                                      };

            private Because b = () => result = sut.Index();

            private It should_return_pageviewmodel_with_employees =
                () =>
                result.ShouldBeAView().And().ShouldHaveAModelOfType<EmployeePageViewModel>().SummaryEmployeeViewModels.Count().
                    ShouldEqual(1);

            private static IEmployeePageViewModelMapper the_page_view_model_mapper;
            private static EmployeePageViewModel the_page_view_model;
            private static IList<SummaryEmployeeViewModel> the_employee_summary_view_model;
        }
    }
}
