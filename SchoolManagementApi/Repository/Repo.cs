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
            return await entities.SingleOrDefaultAsync(i => i.Id == id);
            
            
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await entities.ToListAsync();
        }
        public async Task<T> GetByFilter(string filter)
        {
            
            return await  entities.FindAsync(filter);
            
            
        }
        public async Task Create(T entity)
        {           
            await context.AddAsync(entity);
        }

        public  void Delete(T entity)
        {
            
            
            
             entities.Remove(entity);           
        }


        public async Task Save()
        {
            await context.SaveChangesAsync();
        }

        public  void Update(T entity)
        {
            
            entities.Update(entity);
            //await Save();
        }
    }
}
