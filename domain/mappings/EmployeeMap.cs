using FluentNHibernate.Mapping;

namespace domain.mappings
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Email);
            HasOne(x => x.Title);
        }
    }
}
