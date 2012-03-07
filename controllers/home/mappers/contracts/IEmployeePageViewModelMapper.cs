using System.Collections.Generic;
using controllers.home.viewmodels;
using domain;

namespace controllers.home.mappers.contracts
{
    public interface IEmployeePageViewModelMapper
    {
        EmployeePageViewModel MapFrom(IEnumerable<Employee> employees);
    }
}