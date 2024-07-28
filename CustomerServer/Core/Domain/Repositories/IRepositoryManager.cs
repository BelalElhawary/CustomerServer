using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerServer.Core.Domain.Repositories
{
    public interface IRepositoryManager
    {
        ICustomerRepository CustomerRepository { get; }
        IUnitOfWork UnitOfWork { get; }
    }
}