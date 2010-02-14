using System.Collections.Generic;
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
