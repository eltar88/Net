
using FluentNHibernate.Mapping;
using RepositoryPatternMyTest.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternMyTest.ORM.Mapping.Nhibernate
{
    class OrderMap :ClassMap<Order>
    {
        public OrderMap()
        {
            Id(x => x.ID);
            Map(x => x.OrderDate).Not.Nullable();
            Map(x => x.OrderTotal).Not.Nullable();
            References(x => x.Customer).Not.Nullable();
            HasMany(x => x.LineItems).Access.CamelCaseField().Inverse().Cascade.AllDeleteOrphan();

        }

    }
}
