using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerServer.Core.Service.Abstractions;
using CustomerServer.Shared;

namespace CustomerServer.Core.Services
{
    public class CountryService : ICountryService
    {
        public Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CountryDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<CountryDto> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}