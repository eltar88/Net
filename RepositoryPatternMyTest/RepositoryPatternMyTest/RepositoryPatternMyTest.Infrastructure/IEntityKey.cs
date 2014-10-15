using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternMyTest.Infrastructure
{
    public interface IEntityKey<TKey>
    {
        TKey Id { get; }
    }
}
