using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerServer.Shared;

namespace CustomerServer.Core.Service.Abstractions
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<CustomerDto> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<CustomerDto> CreateAsync(CreateCustomerDto createCustomerDto, CancellationToken cancellationToken = default);
        Task UpdateAsync(int id, UpdateCustomerDto updateCustomerDto, CancellationToken cancellationToken = default);
        Task DeleteAsync(int id, CancellationToken cancellationToken = default);
    }
}