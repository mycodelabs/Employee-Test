using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Data;
using NHibernate;

namespace infrastructure.configuration
{
    public static class SessionFactory
    {
        public static ISessionFactory BuildSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                              .ConnectionString(c => c
                                                         .FromConnectionStringWithKey("ApplicationServices"))
                              .ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<domain.Entity>())
                .Cache(x => x.UseQueryCache()
                                .UseMinimalPuts()
                                .UseSecondLevelCache())
                .BuildSessionFactory();
        }
    }
}