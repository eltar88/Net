using RepositoryPatternMyTest.DomainModel;
using RepositoryPatternMyTest.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRepositoryPatternMyTest.DomainModel
{
    public class Customer : Entity<Customer, int>
    {
        public virtual string CustomerIdentifier { get; protected set; }
        public virtual Name CustomerName { get; protected set; }
        public virtual Address Address { get; set; }
        private readonly List<Order> orders;
        public virtual IEnumerable<Order> Orders { get { return orders; } }

        public virtual void ChangeCustomerName(string firstName, string middleName, string lastName, string customeridentifier)
        {
            CustomerName = new Name(firstName, middleName, lastName);
            CustomerIdentifier = customeridentifier;
        }

        public virtual void PlaceOrder(LineInfo[] lineInfos,IDictionary<int, Product> products)
        {
            var order = new Order(this);
            foreach (var lineInfo in lineInfos)
            {
                var product = products[lineInfo.ProductId];
                order.AddProduct(this, product, lineInfo.Quantity);
            }
            orders.Add(order);
        }


    }
}
