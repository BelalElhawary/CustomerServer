using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerServer.Core.Domain.Repositories;
using CustomerServer.Core.Service.Abstractions;

namespace CustomerServer.Core.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICustomerService> _lazyCustomerService;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyCustomerService = new Lazy<ICustomerService>(() => new CustomerService(repositoryManager));
        }

        public ICustomerService CustomerService => _lazyCustomerService.Value;
    }
}