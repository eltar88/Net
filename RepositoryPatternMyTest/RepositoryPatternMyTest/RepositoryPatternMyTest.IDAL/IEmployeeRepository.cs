using RepositoryPatternMyTest.DomainModel;
using RepositoryPatternMyTest.Infrastructure;

namespace RepositoryPatternMyTest.IDAL
{
    public interface IEmployeeRepository : IPersistRepository<Employee>, IReadOnlyRepository<Employee, long>
    {
    }
}