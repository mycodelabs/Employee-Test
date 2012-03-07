using System.Collections.Generic;
using System.Linq;
using domain;
using infrastructure.configuration;
using NHibernate;
using tasks.contracts;

namespace infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            var sessionFactory = SessionFactory.BuildSessionFactory();

            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    return session.CreateCriteria(typeof (Employee)).List<Employee>().AsEnumerable();
                }
            }
        }
    }
}