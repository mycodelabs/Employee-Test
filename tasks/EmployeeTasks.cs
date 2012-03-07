using System;
using System.Collections.Generic;
using System.Linq;
using controllers.home.contracts;
using domain;
using tasks.contracts;

namespace tasks
{
    public class EmployeeTasks : IEmployeeTasks
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeTasks(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public IList<Employee> GetAll()
        {
            var employees = this.employeeRepository.GetAll();
            return employees.ToList();
        }
    }
}
