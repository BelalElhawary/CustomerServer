using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerServer.Core.Domain.Entities
{
    public class BaseObject
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}