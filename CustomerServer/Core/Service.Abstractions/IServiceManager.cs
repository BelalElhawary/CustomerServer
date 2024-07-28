using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerServer.Core.Service.Abstractions;

namespace CustomerServer.Core.Service.Abstractions
{
    public interface IServiceManager
    {
        ICustomerService CustomerService { get; }
    }
}