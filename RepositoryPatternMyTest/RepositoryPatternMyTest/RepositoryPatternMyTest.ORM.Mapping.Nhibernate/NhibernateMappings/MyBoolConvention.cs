using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace RepositoryPatternMyTest.ORM.Mapping.Nhibernate.NhibernateMappings
{
    class MyBoolConvention : IPropertyConvention
    {
        public void Apply(IPropertyInstance instance)
        {
            if (instance.Type == typeof(bool))
            {
                instance.CustomType("YesNo");
            }
        }
    }
}
