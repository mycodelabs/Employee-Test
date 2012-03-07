using System.Collections.Generic;
using domain;

namespace controllers.home.contracts
{
    public interface IEmployeeTasks
    {
        IList<Employee> GetAll();
    }
}