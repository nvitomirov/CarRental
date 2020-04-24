using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.DataModel;
using CarRental.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {

        private IVehicleRepository _vehicleRepository;

        public VehiclesController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        // GET: Vehicles
        [HttpGet]
        [ProducesResponseType(typeof(List<Vehicle>), 200)]
        public async Task<ActionResult> Get()
        {
            var vehicles = await _vehicleRepository.GetAllAsync();
            return Ok(vehicles);
        }

        // GET: Vehicles/[Guid]
        [HttpGet("{id}", Name = "Get")]
        [ProducesResponseType(typeof(Vehicle), 200)]
        public async Task<ActionResult> Get(Guid id)
        {
            var vehicle = await _vehicleRepository.GetByIdAsync(id);
            if (vehicle == null)
                return NotFound();
            return Ok(vehicle);
        }

        
        // POST: Vehicles
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: Vehicles/[Guid]
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] string value)
        {
        }

        // DELETE: ApiWithActions/[Guid]
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
