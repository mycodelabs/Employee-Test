using FluentNHibernate.Mapping;

namespace domain.mappings
{
    public class JobTitleMap : ClassMap<JobTitle>
    {
        public JobTitleMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}
