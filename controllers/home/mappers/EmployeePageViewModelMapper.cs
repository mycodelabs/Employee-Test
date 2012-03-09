using System.Collections.Generic;
using controllers.home.mappers.contracts;
using controllers.home.viewmodels;
using domain;

namespace controllers.home.mappers
{
    public class EmployeePageViewModelMapper : IEmployeePageViewModelMapper
    {
        public EmployeePageViewModel MapFrom(IEnumerable<Employee> employees)
        {
            var pageViewModel = new EmployeePageViewModel(); 
            foreach (var employee in employees)
            {
                pageViewModel.SummaryEmployeeViewModels.Add(new SummaryEmployeeViewModel()
                                                                {
                                                                    Id = employee.Id,
                                                                    Email = employee.Email,
                                                                    JobTitle =
                                                                        employee.Title != null
                                                                            ? employee.Title.Name
                                                                            : string.Empty,
                                                                    Name = employee.Name
                                                                });
            }
            return pageViewModel;
        }
    }
}