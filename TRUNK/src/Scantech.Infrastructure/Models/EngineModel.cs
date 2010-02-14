using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scantech.Infrastructure.Models
{
    class EngineModel
    {
        public enum CylinderArrangement
        {
            V8,
            InLine,
            Boxer
        }

        public CylinderArrangement CylinderConfiguration { get; set; }
        public int NumberOfCylinders { get; set; }
        public float Displacement { get; set; }
    }
}
