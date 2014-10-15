
using FluentNHibernate.Mapping;
using RepositoryPatternMyTest.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternMyTest.ORM.Mapping.Nhibernate
{
    class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.ID);
            Map(x => x.Name).Not.Nullable().Length(50);
            Map(x => x.Description).Length(50);
            Map(x => x.UnitPrice).Not.Nullable();
            Map(x => x.ReorderLevel).Not.Nullable();
            Map(x => x.Discontinued);
        }
    }
}
