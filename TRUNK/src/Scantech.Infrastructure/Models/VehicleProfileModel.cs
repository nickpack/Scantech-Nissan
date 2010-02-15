using System;

namespace Scantech.Infrastructure.Models
{
    public class VehicleProfileModel
    {
        public DateTime YearOfManufacture { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public ECUModel ECU { get; set; }
        public EngineModel Engine { get; set; }
    }
}
