using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternMyTest.DomainModel
{
   public class Name
    {
        public virtual string LastName { get; private set; }
        public virtual string FirstName { get; private set; }
        public virtual string MiddleName { get; private set; }

        public Name(string firstName, string middleName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name must be defined.");
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Last name must be defined.");
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
        public Name()
        {
        }
        public override int GetHashCode()
        {
            unchecked
            {
                var result = FirstName.GetHashCode();
                result = (result * 397) ^ (MiddleName != null ?
                  MiddleName.GetHashCode() : 0);
                result = (result * 397) ^ LastName.GetHashCode();
                return result;
            }
        }
        public virtual bool Equals(Name other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.FirstName, FirstName) &&
              Equals(other.MiddleName, MiddleName) &&
              Equals(other.LastName, LastName);
        }
        public override bool Equals(object other)
        {
            return Equals(other as Name);
        }

    }
}
