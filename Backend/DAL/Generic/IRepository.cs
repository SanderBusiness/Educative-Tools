namespace DAL.Generic;

public interface IRepository<T, in TK>
{
    Task<T> Update(T entity);
    Task<int> Update(List<T> entity);
    Task<List<T>> Read();
    ValueTask<T?> Read(TK key);
    Task<T> Create(T entity);
    Task Create(List<T> entities);
    Task<int> Delete(T entity);
    Task<int> Delete(List<T> entity);
}