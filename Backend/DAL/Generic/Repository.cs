using DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace DAL.Generic;

public abstract class Repository<T, TK> : IRepository<T, TK> where T : class
{
    protected Repository(ApplicationContext db)
    {
        Db = db;
        Table = Db.Set<T>();
    }

    protected DbSet<T> Table { get; }

    protected ApplicationContext Db { get; }

    public async Task<T> Update(T entity)
    {
        Table.Update(entity);
        await Db.SaveChangesAsync();
        return entity;
    }

    public ValueTask<T?> Read(TK key)
    {
        return Table.FindAsync(key);
    }

    public async Task<int> Update(List<T> entities)
    {
        Table.UpdateRange(entities);
        return await Db.SaveChangesAsync();
    }

    public async Task<T> Create(T entity)
    {
        Table.Add(entity);
        await Db.SaveChangesAsync();
        return entity;
    }

    public Task Create(List<T> entities)
    {
        return Table.AddRangeAsync(entities);
    }

    public Task<int> Delete(T entity)
    {
        Table.Remove(entity);
        return Db.SaveChangesAsync();
    }

    public Task<int> Delete(List<T> entities)
    {
        Table.RemoveRange(entities);
        return Db.SaveChangesAsync();
    }

    public Task<List<T>> Read()
    {
        return Table.ToListAsync();
    }
}