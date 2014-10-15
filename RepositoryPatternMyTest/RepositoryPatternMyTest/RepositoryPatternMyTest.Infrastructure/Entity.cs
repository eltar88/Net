using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternMyTest.Infrastructure
{
    public abstract class Entity<TEntity,TEntityKey> where TEntity : Entity<TEntity,TEntityKey>
    {
        public virtual TEntityKey ID { get; private set; }
        public override bool Equals(object obj)
        {
            var other = obj as TEntity;
            if (other == null) return false;
            var thisIsNew = Equals(ID, default(TEntityKey));
            var otherIsNew = Equals(other.ID, default(TEntityKey));
            if (thisIsNew && otherIsNew)
                return ReferenceEquals(this, other);
            return ID.Equals(other.ID);
        }
        
        private int? oldHashCode;

        public override int GetHashCode()
        {
            // once we have a hashcode we'll never change it
            if (oldHashCode.HasValue)
                return oldHashCode.Value;
            // when this instance is new we use the base hash code
            // and remember it, so an instance can NEVER change its
            // hash code.
            var thisIsNew = Equals(ID, default(TEntityKey));
            if (thisIsNew)
            {
                oldHashCode = base.GetHashCode();
                return oldHashCode.Value;
            }
            return ID.GetHashCode();
        }
        public static bool operator ==(Entity<TEntity,TEntityKey> lhs, Entity<TEntity,TEntityKey> rhs)
        {
            return Equals(lhs, rhs);
        }
        public static bool operator !=(Entity<TEntity,TEntityKey> lhs, Entity<TEntity,TEntityKey> rhs)
        {
            return !Equals(lhs, rhs);
        }

    }
}
