using SchoolManagementApi.Data;

namespace SchoolManagementApi.Repository;

public interface IRepo<T> where T : BaseEntity
{
    Task<IEnumerable<T>> GetAll();
    Task<T> Get(Guid id);
    void Update(T entity);
    void Delete(T entity);
    Task Create(T entity);
    Task<T> GetByFilter(string filter);
    Task Save();
}
