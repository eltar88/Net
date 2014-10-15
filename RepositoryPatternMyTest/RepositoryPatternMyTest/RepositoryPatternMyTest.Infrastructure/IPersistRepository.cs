using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternMyTest.Infrastructure
{
    public interface IPersistRepository<TEntity> : IQueryable<TEntity>
    {
        bool Add(TEntity entity);
        bool Add(IEnumerable<TEntity> items);

        bool Delete(TEntity entity);
        bool Delete(IEnumerable<TEntity> entities);

        bool Update(TEntity entity);
    }
}
