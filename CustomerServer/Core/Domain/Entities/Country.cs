using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerServer.Core.Domain.Entities;

namespace Domain.Entities
{
    public class Country : BaseObject
    {
        public required string Name { get; set; }
        public List<City> Cities { get; set; }
    }
}