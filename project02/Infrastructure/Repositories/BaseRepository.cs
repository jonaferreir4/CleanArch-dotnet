using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using project02.Core.Domain.Entities;

namespace project02.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {

        protected readonly AppDbContext Context;

        public BaseRepository(AppDbContext context)
        {
            Context = context;
        }

        public void Create(T entity)
        {
            entity.DateCreated = DateTime.UtcNow;
            Context.Add(entity);
        }

        public void Delete(T entity)
        {
            entity.DateDeleted = DateTime.UtcNow;
            Context.Remove(entity);
        }

        public async Task<T> Get(Guid id, CancellationToken cancellationToken)
        {  
            return await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<List<T>> GetAll(CancellationToken cancellationToken)
        {
            return await Context.Set<T>().ToListAsync(cancellationToken);
        }

        public void Update(T entity)
        {
            entity.DateUpdated = DateTime.UtcNow;
            Context.Update(entity);
        }
    }
}