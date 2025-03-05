using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project02.Core.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }

        
    }
}