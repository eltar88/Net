using FluentNHibernate.Mapping;
using RepositoryPatternMyTest.DomainModel;

namespace RepositoryPatternMyTest.ORM.Mapping.Nhibernate.NhibernateMappings
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(x => x.ID);
            Component(x => x.Name);
        }
    }
}
