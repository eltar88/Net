using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternMyTest.Infrastructure
{
    public interface IReadOnlyRepository<TEntity, TEntityKey> where TEntity : class
    {
        TEntity Get(TEntityKey id);
        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> FilterBy(Expression<Func<TEntity, bool>> expression);

        TEntity FindBy(TEntityKey id);
        TEntity FindBy(Expression<Func<TEntity, bool>> expression);
    }

}
