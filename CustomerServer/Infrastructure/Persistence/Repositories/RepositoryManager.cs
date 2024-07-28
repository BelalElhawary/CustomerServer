using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerServer.Core.Domain.Repositories;

namespace CustomerServer.Infrastructure.Persistence.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<ICustomerRepository> _lazyCustomerRepository;
        private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;

        public RepositoryManager(RepositoryDbContext dbContext)
        {
            _lazyCustomerRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(dbContext));
            _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(dbContext));
        }

        public ICustomerRepository CustomerRepository => _lazyCustomerRepository.Value;
        public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;
    }
}