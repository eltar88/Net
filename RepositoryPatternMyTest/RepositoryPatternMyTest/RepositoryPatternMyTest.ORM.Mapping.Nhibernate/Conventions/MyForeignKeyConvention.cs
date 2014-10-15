using System;
using FluentNHibernate.Conventions;

namespace RepositoryPatternMyTest.ORM.Mapping.Nhibernate.Conventions
{
    class MyForeignKeyConvention : ForeignKeyConvention
    {
        protected override string GetKeyName(FluentNHibernate.Member property, Type type)
        {
            var refname = property == null ? type.Name : property.Name;
            return String.Format("{0}_ID", refname);
        }
    }
}
