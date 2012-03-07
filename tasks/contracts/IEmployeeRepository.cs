using System.Collections.Generic;
using domain;

namespace tasks.contracts
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
    }
}