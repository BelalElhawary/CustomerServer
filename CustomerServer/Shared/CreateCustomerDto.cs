using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerServer.Shared
{
    public class CreateCustomerDto
    {
        public required string Name { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public required string Country { get; set; }
        public required string City { get; set; }
    }
}