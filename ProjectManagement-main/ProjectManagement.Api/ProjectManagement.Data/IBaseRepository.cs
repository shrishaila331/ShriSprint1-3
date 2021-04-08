using ProjectManagement.Entities;
using System.Collections.Generic;

namespace ProjectManagement.Data.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IEnumerable<T> Get();

        T Get(long id);

        T Add(T entity);

        T Update(T entity);

        void Delete(long id);

    }
}
