using DRepositoryPatternMyTest.DomainModel;
using RepositoryPatternMyTest.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternMyTest.DomainModel
{
   public class Order : Entity<Order, int>
    {
       public virtual Customer Customer { get; set; }
       public virtual Employee Reference { get; set; }
       public virtual DateTime OrderDate { get; set; }
       public virtual decimal OrderTotal { get; set; }

        private readonly IList<LineItem> lineItems;
        public virtual IEnumerable<LineItem> LineItems { get { return lineItems; } }

        public Order()
        {
        }
        public Order(Customer customer)
        {
            lineItems = new List<LineItem>();
            Customer = customer;
            OrderDate = DateTime.Now;
        }
        public virtual void AddProduct(Customer customer, Product product,int quantity)
        {
            Customer = customer;
            var line = new LineItem(this, quantity, product);
            lineItems.Add(line);
        }

    }
}
