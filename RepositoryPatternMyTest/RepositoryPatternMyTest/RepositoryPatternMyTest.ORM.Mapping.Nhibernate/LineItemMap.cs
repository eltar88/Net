
using FluentNHibernate.Mapping;
using RepositoryPatternMyTest.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternMyTest.ORM.Mapping.Nhibernate
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
