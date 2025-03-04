using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface UnitOfWork
    {
        Task Commit(CancellationToken cancellationToken );
    }
}