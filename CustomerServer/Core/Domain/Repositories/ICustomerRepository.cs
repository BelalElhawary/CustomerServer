using CustomerServer.Core.Domain.Entities;

namespace CustomerServer.Core.Domain.Repositories;

public interface ICustomerRepository
{
    Task<IEnumerable<Customer>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Customer> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    void Insert(Customer customer);
    void Remove(Customer customer);
}