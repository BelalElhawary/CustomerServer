using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerServer.Core.Service.Abstractions;
using CustomerServer.Shared;
using Microsoft.AspNetCore.Mvc;


namespace CustomerServer.Infrastructure.Presentation.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController(IServiceManager serviceManager) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetCustomers(CancellationToken cancellationToken)
        {
            var customers = await serviceManager.CustomerService.GetAllAsync(cancellationToken);

            return Ok(customers);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCustomerById(int id, CancellationToken cancellationToken)
        {
            var customer = await serviceManager.CustomerService.GetByIdAsync(id, cancellationToken);

            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerDto createCustomerDto)
        {
            var customer = await serviceManager.CustomerService.CreateAsync(createCustomerDto);

            return CreatedAtAction(nameof(GetCustomerById), new { id = customer.Id }, customer);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateCustomer(int id, [FromBody] UpdateCustomerDto updateCustomerDto, CancellationToken cancellationToken)
        {
            await serviceManager.CustomerService.UpdateAsync(id, updateCustomerDto, cancellationToken);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteCustomer(int id, CancellationToken cancellationToken)
        {
            await serviceManager.CustomerService.DeleteAsync(id, cancellationToken);

            return NoContent();
        }
    }
}