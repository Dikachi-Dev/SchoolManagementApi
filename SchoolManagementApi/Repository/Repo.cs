using Microsoft.EntityFrameworkCore;
using SchoolManagementApi.Data;

namespace SchoolManagementApi.Repository
{
    public class Repo<T> : IRepo<T> where T : BaseEntity
    {
        private readonly SchoolManagementApiContext context;
        private readonly DbSet<T> entities;

        public Repo(SchoolManagementApiContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public async Task<T> Get(Guid id)
        {
            ArgumentNullException.ThrowIfNull(id);
            var result = await entities.SingleOrDefaultAsync(i => i.Id == id);
            ArgumentNullException.ThrowIfNull(result);
            return result;
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await entities.ToListAsync();
        }
        public async Task<T> GetByFilter(string filter)
        {
            ArgumentNullException.ThrowIfNull(filter);
            var result = await  entities.FindAsync(filter);
            ArgumentNullException.ThrowIfNull(result);
            return result;
        }
        public async Task Create(T entity)
        {
            ArgumentNullException.ThrowIfNull(entity);
            await context.AddAsync(entity);
        }

        public async Task Delete(Guid id)
        {
            
            ArgumentNullException.ThrowIfNull(id);
            var result = await Get(id);
            ArgumentNullException.ThrowIfNull(result);
            entities.Remove(result);           
        }


        public async Task Save()
        {
            await context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            ArgumentNullException.ThrowIfNull(entity);
            entities.Update(entity);
            await Save();
        }
    }
}
