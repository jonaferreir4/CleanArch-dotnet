using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project02.Core.Domain.Entities
{
    public class BaseEntity
    {
        public Guid id { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public DateTimeOffset? DateDeleted { get; set; }

        
    }
}