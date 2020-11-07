using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreAPIAngular.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NetCoreAPIAngular.WebAPI.Controllers
{
    public class BaseAPIController<T> : IBaseAPIController<T> where T : class
    {
        #region Fields

        protected DataContext Context;

        #endregion

        public BaseAPIController(DataContext context)
        {
            Context = context;
        }

        #region Public Methods
        
        [HttpGet("id: int")]
        public async Task<T> GetById(int id)
        {
            return await  Context.Set<T>().FindAsync(id);
        }

        [HttpGet("search")]
        public Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate)
            => Context.Set<T>().FirstOrDefaultAsync(predicate);
        
        [HttpPost]
        public async Task Add(T entity)
        {
            // await Context.AddAsync(entity);
            await Context.Set<T>().AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        [HttpPatch]
        public Task Update(T entity)
        {
            // In case AsNoTracking is used
            Context.Entry(entity).State = EntityState.Modified;
            return Context.SaveChangesAsync();
        }

        [HttpDelete]
        public Task Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
            return Context.SaveChangesAsync();
        }

        [HttpGet]
        public async Task<IEnumerable<T>> GetAll()
        {
            return await Context.Set<T>().ToListAsync();
        }

        [HttpGet("getwhere")]
        public async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return await Context.Set<T>().Where(predicate).ToListAsync();
        }

        [HttpGet("count")]
        public Task<int> CountAll() => Context.Set<T>().CountAsync();

        [HttpGet("where")]
        public Task<int> CountWhere(Expression<Func<T, bool>> predicate)
            => Context.Set<T>().CountAsync(predicate);

        #endregion
    }
}