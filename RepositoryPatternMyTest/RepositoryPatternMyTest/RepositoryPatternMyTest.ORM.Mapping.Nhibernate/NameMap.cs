
using FluentNHibernate.Mapping;
using RepositoryPatternMyTest.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternMyTest.ORM.Mapping.Nhibernate
{
    public class NameMap : ComponentMap<Name>
    {
        public NameMap()
        {
            Map(x => x.LastName).Not.Nullable() .Length(100);
            Map(x => x.FirstName).Not.Nullable().Length(100);
            Map(x => x.MiddleName).Length(100);
        }
    }

}
