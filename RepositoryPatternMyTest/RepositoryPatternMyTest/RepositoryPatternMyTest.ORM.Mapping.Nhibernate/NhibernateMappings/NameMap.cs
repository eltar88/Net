using FluentNHibernate.Mapping;
using RepositoryPatternMyTest.DomainModel;

namespace RepositoryPatternMyTest.ORM.Mapping.Nhibernate.NhibernateMappings
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
