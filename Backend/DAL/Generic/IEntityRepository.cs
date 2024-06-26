using Domain.Abstract;

namespace DAL.Generic;

public interface IEntityRepository<T, in TK> : IRepository<T, TK> where T : Entity
{
    Task<List<T>> Read(int page, int rows, bool asc);
}