using LeaveManagement.Application.Contracts;
using LeaveManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Application.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)
        {
            //Constructor for applicationdbcontext
            this.context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
           await context.AddAsync(entity); //Adds to the db
            await context.SaveChangesAsync(); //Saves changes
            return entity;
        }

        public async Task AddRangeAsync(List<T> entities)
        {
            await context.AddRangeAsync(entities); //tracks changes in the database, that will be inserted once savechanges is called
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            if (entity != null)
            {
                context.Set<T>().Remove(entity);
            }
            await context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
           return await context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetAsync(int? id)
        {
            if(id == null)
            {
                return null;
            }
            return await context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
          
            context.Update(entity); //Updated database
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        
    }
}
