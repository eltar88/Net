﻿using FluentNHibernate.Mapping;
using RepositoryPatternMyTest.DomainModel;

namespace RepositoryPatternMyTest.ORM.Mapping.Nhibernate.NhibernateMappings
{
    public class AddressMap : ComponentMap<Address>
    {
        public AddressMap()
        {
            Map(x => x.Line1).Not.Nullable().Length(50);
            Map(x => x.Line2).Length(50);
            Map(x => x.ZipCode).Not.Nullable().Length(10);
            Map(x => x.City).Not.Nullable().Length(50);
            Map(x => x.State).Not.Nullable().Length(50);
        }
    }

}
