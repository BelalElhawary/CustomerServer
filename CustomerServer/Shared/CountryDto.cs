using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerServer.Shared
{
    public class CountryDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required List<CityDto> Cities { get; set; }
    }
}