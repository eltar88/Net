
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using RepositoryPatternMyTest.Infrastructure;
namespace RepositoryPatternMyTest.ORM.Nhibernate
{
    public class Repository<TEntity, TEntityKey> : IPersistRepository<TEntity>, IReadOnlyRepository<TEntity, TEntityKey> where TEntity : class
    {
        private readonly ISession session;
        public Repository(ISession Session)
        {
            session = Session;
        }


        public TEntity Get(TEntityKey key)
        {
           return session.Get<TEntity>(key);
        }
        public bool Add(TEntity entity)
        {
            session.Save(entity);
            return true;
        }

        public bool Add(System.Collections.Generic.IEnumerable<TEntity> items)
        {
            foreach (TEntity item in items)
            {
                session.Save(item);
            }
            return true;
        }

        public bool Update(TEntity entity)
        {
            session.Update(entity);
            return true;
        }

        public bool Delete(TEntity entity)
        {
            session.Delete(entity);
            return true;
        }

        public bool Delete(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            foreach (TEntity entity in entities)
            {
                session.Delete(entity);
            }
            return true;
        }

        public IQueryable<TEntity> GetAll()
        {
            return session.Query<TEntity>();
        }

        public TEntity FindBy(System.Linq.Expressions.Expression<Func<TEntity, bool>> expression)
        {
            return FilterBy(expression).SingleOrDefault();
        }

        public IQueryable<TEntity> FilterBy(System.Linq.Expressions.Expression<Func<TEntity, bool>> expression)
        {
            return GetAll().Where(expression).AsQueryable();
        }

        public TEntity FindBy(TEntityKey id)
        {
            return session.Get<TEntity>(id);
        }

        public Type ElementType
        {
            get { return session.Query<TEntity>().ElementType; }
        }

        public Expression Expression
        {
            get { return session.Query<TEntity>().Expression; }
        }

        public IQueryProvider Provider
        {
            get { return session.Query<TEntity>().Provider; }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            return session.Query<TEntity>().GetEnumerator();
        }
    }
}
