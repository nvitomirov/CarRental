using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Repositories
{
    public interface CreateReadUpdateRepository<T> where T : class
    {
        Task<T> InsertAsync(T entity);

        Task<T> GetByIdAsync(Guid id);

        Task<List<T>> GetAllAsync();

        Task<bool> UpdateAsync(T entity);

    }
}
