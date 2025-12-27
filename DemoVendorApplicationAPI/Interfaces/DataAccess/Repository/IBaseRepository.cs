namespace DemoVendorApplicationAPI.Interfaces.DataAccess.Repository;

public interface IBaseRepository<T>
{
    Task<List<T>> GetList();
    Task<List<T>> GetList(Guid id);
    Task<T> GetById(Guid id);
    Task<T> Create(T entity);
    Task<T> Update(T entity);
    Task<T> Delete(Guid Id);
}
