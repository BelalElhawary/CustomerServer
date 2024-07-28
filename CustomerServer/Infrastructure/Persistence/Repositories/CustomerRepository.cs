using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerServer.Core.Domain.Entities;
using CustomerServer.Core.Domain.Repositories;
using CustomerServer.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CustomerServer.Infrastructure.Persistence.Repositories
{
    internal sealed class CustomerRepository(RepositoryDbContext dbContext) : ICustomerRepository
    {
        public async Task<IEnumerable<Customer>> GetAllAsync(CancellationToken cancellationToken = default) =>
            await dbContext.Customers.ToListAsync();

        public async Task<Customer> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
            await dbContext.Customers.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        public void Insert(Customer customer) => dbContext.Customers.Add(customer);

        public void Remove(Customer customer) => dbContext.Customers.Remove(customer);
    }
}