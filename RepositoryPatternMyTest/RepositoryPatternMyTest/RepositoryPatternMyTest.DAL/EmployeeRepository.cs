using NHibernate;
using RepositoryPatternMyTest.DomainModel;
using RepositoryPatternMyTest.ORM.Nhibernate;

namespace RepositoryPatternMyTest.IDAL
{
    public class EmployeeRepository : Repository<Employee, long>, IEmployeeRepository
    {
        public EmployeeRepository(ISession Session) : base(Session)
        {
            
        }
    }
}