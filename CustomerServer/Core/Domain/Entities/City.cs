using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerServer.Core.Domain.Entities;

namespace Domain.Entities
{
    public class City : BaseObject
    {
        public required string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}