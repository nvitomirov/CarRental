using CarRental.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Repositories
{
    public interface IVehicleRepository : CreateReadUpdateRepository<Vehicle>, DeleteRepository
    {
    }
}
