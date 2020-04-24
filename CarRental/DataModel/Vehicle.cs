using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.DataModel
{
    public class Vehicle
    {
        public Guid Id { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int SeatingCapacity { get; set; }

        public string Class { get; set; }

    }
}
