using DRepositoryPatternMyTest.DomainModel;
using FluentNHibernate.Mapping;

namespace RepositoryPatternMyTest.ORM.Mapping.Nhibernate.NhibernateMappings
{
    class CustomerMap :ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(x => x.ID);
            Component(x => x.CustomerName);
            Map(x => x.CustomerIdentifier).Not.Nullable().Length(50);
            Component(x => x.Address);
            HasMany(x => x.Orders).Inverse().Cascade.AllDeleteOrphan();
        }
    }
}
