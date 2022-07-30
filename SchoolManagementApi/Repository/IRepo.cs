using SchoolManagementApi.Data;

namespace SchoolManagementApi.Repository;

public interface IRepo<T> where T : BaseEntity
{
    Task<IEnumerable<T>> GetAll();
    Task<T> Get(Guid id);
    Task Update(T entity);
    Task Delete(Guid id);
    Task Create(T entity);
    Task<T> GetByFilter(string filter);
    Task Save();
}
