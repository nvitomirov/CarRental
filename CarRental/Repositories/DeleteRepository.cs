using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Repositories
{
    public interface DeleteRepository
    {
        Task<bool> Delete(Guid id);
    }
}
