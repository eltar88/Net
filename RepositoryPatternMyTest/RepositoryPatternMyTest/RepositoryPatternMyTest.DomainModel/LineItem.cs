using RepositoryPatternMyTest.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternMyTest.DomainModel
{
   public class LineItem: Entity<LineItem,int>
    {
       public virtual Order Order { get; set; }
       public virtual Product Product { get; set; }
       public virtual int Quantity { get; set; }
       public virtual decimal UnitPrice { get; set; }
       public virtual decimal Discount { get; set; }

       public LineItem()
       {
       }

        public LineItem(Order order, int quantity, Product product)
        {
            Order = order;
            Quantity = quantity;
            Product = product;
            UnitPrice = product.UnitPrice;
            if (quantity >= 10)
                Discount = 0.05m;
        }

    }
}
