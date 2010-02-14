using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scantech.Infrastructure.Models
{
    class VehicleProfileModel
    {
        public DateTime YearOfManufacture { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public ECUModel ECU { get; set; }
        public EngineModel Engine { get; set; }
    }
}
