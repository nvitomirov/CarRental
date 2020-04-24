using CarRental.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {

        private CarRentalDataContext _context;

        public VehicleRepository(CarRentalDataContext context)
        {
            _context = context;
        }

        public async Task<Vehicle> InsertAsync(Vehicle vehicle)
        {
            _context.Add(vehicle);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

            }
            return vehicle;
        }

        public async Task<List<Vehicle>> GetAllAsync()
        {
            try
            {
                return await _context.Vehicles.ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Vehicle> GetByIdAsync(Guid id)
        {
            return await _context.Vehicles.SingleOrDefaultAsync(x => x.Id == id);
        }

      

        public Task<bool> UpdateAsync(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
