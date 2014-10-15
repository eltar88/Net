using RepositoryPatternMyTest.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternMyTest.DomainModel
{
   public class Employee : Entity<Employee,int>
    {
       virtual public Name Name { get; set; }
    }
}
