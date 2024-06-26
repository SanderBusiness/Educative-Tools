using DAL.EF;
using Domain.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DAL.Generic;

public class EntityRepository<T, TK>(ApplicationContext db) : Repository<T, TK>(db), IEntityRepository<T, TK>
    where T : Entity
{
    public async Task<List<T>> Read(int page, int rows, bool asc)
    {
        var q = Table.AsQueryable();
        q = asc ? q.OrderBy(e => e.CreatedOn) : q.OrderByDescending(e => e.CreatedOn);
        return await q.Skip(page * rows)
            .Take(rows)
            .ToListAsync();
    }
}