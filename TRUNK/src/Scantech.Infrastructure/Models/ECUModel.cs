using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Scantech.Infrastructure.Models.Registers;

namespace Scantech.Infrastructure.Models
{
    class ECUModel
    {
        string ECUID { get; set; }
        List<IRegisterModel> Registers { get; set; }
        List<int> FaultCodes { get; set; }
    }
}
