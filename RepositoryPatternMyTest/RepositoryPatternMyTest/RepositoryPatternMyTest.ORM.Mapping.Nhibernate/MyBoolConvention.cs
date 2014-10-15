using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternMyTest.ORM.Mapping.Nhibernate
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
