using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace RepositoryPatternMyTest.ORM.Mapping.Nhibernate.Conventions
{
    public class MyIdConvention : IIdConvention
    {
        public void Apply(IIdentityInstance instance)
        {
            instance.GeneratedBy.Native();
        }
    }

}
