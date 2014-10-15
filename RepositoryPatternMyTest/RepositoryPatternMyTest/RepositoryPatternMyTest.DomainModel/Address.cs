using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternMyTest.DomainModel
{
   public class Address
    {
        public virtual string Line1 {get; set;}
        public virtual string Line2{get; set;}
        public virtual string ZipCode { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual bool Equals(Address other)
        {
            if (other == null) return false;

            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Line1, Line1) &&
              Equals(other.Line2, Line2) &&
              Equals(other.ZipCode, ZipCode) &&
              Equals(other.City, City) &&
              Equals(other.State, State);
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Address);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                var result = Line1.GetHashCode();
                result = (result * 397) ^ (Line2 != null ?
                  Line2.GetHashCode() : 0);
                result = (result * 397) ^ ZipCode.GetHashCode();
                result = (result * 397) ^ City.GetHashCode();
                result = (result * 397) ^ State.GetHashCode();
                return result;
            }
        }
    }
}
