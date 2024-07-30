using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerServer.Shared;

namespace CustomerServer.Core.Service.Abstractions
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<CountryDto> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        // Task<CountryDto> CreateAsync(CreateCountryDto createCustomerDto, CancellationToken cancellationToken = default);
        // Task UpdateAsync(int id, UpdateCountryDto updateCustomerDto, CancellationToken cancellationToken = default);
        Task DeleteAsync(int id, CancellationToken cancellationToken = default);
    }
}