using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerServer.Core.Domain.Entities;
using CustomerServer.Core.Domain.Exceptions;
using CustomerServer.Core.Domain.Repositories;
using CustomerServer.Core.Service.Abstractions;
using CustomerServer.Shared;
using Mapster;

namespace CustomerServer.Core.Services
{
    internal sealed class CustomerService : ICustomerService
    {
        private readonly IRepositoryManager _repositoryManager;

        public CustomerService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

        public async Task<CustomerDto> CreateAsync(CreateCustomerDto createCustomerDto, CancellationToken cancellationToken = default)
        {
            var customer = createCustomerDto.Adapt<Customer>();

            _repositoryManager.CustomerRepository.Insert(customer);

            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);

            return customer.Adapt<CustomerDto>();
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var customer = await _repositoryManager.CustomerRepository.GetByIdAsync(id, cancellationToken);

            if (customer is null)
                throw new CustomerNotFoundException(id);

            _repositoryManager.CustomerRepository.Remove(customer);

            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IEnumerable<CustomerDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var customers = await _repositoryManager.CustomerRepository.GetAllAsync(cancellationToken);

            var customersDto = customers.Adapt<IEnumerable<CustomerDto>>();

            return customersDto;
        }

        public async Task<CustomerDto> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var customer = await _repositoryManager.CustomerRepository.GetByIdAsync(id, cancellationToken);

            if (customer is null)
                throw new CustomerNotFoundException(id);

            var customerDto = customer.Adapt<CustomerDto>();

            return customerDto;
        }

        public async Task UpdateAsync(int id, UpdateCustomerDto updateCustomerDto, CancellationToken cancellationToken = default)
        {
            var customer = await _repositoryManager.CustomerRepository.GetByIdAsync(id, cancellationToken);

            if (customer is null)
                throw new CustomerNotFoundException(id);

            if (updateCustomerDto.Name is not null)
                customer.Name = updateCustomerDto.Name;

            if (updateCustomerDto.Address is not null)
                customer.Address = updateCustomerDto.Address;

            if (updateCustomerDto.PhoneNumber is not null)
                customer.PhoneNumber = updateCustomerDto.PhoneNumber;

            if (updateCustomerDto.Country is not null)
            {
                customer.Country = updateCustomerDto.Country;

                if (updateCustomerDto.City is not null)
                    customer.City = updateCustomerDto.City;
            }

            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}