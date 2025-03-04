using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project02.Core.Domain.Entities;

namespace Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

        Task<T> Get(Guid id, CancellationToken cancellationToken);
        Task<List<T>> GetAll(CancellationToken cancellationToken);
         
    }
}