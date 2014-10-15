using FluentNHibernate.Mapping;
using RepositoryPatternMyTest.DomainModel;

namespace RepositoryPatternMyTest.ORM.Mapping.Nhibernate.NhibernateMappings
{
    class LineItemMap : ClassMap<LineItem>
    {
        public LineItemMap()
        {
            Id(x => x.ID);
            References(x => x.Order).Not.Nullable();
            References(x => x.Product).Not.Nullable();
            Map(x => x.Quantity).Not.Nullable();
            Map(x => x.UnitPrice).Not.Nullable();
            Map(x => x.Discount).Not.Nullable();
        }
    }
}
