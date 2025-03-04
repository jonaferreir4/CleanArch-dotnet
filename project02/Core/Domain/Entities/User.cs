using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project02.Core.Domain.Entities;

namespace Domain.Entities
{
    public sealed class User: BaseEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set;}
    }
}