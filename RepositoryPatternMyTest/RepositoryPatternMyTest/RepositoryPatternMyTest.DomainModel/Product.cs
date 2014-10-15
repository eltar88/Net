using RepositoryPatternMyTest.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternMyTest.DomainModel
{
   public class Product:Entity<Product,int>
    {
       public virtual string Name { get; set; }
       public virtual string Description { get; set; }
       public virtual decimal UnitPrice { get; set; }
       public virtual int ReorderLevel { get; set; }
       public virtual bool Discontinued { get; set; }
    }
}
