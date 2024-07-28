using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerServer.Core.Domain.Repositories;

namespace CustomerServer.Infrastructure.Persistence.Repositories
{
    internal sealed class UnitOfWork(RepositoryDbContext dbContext) : IUnitOfWork
    {
        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            await dbContext.SaveChangesAsync();
    }
}