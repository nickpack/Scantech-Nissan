using System.Collections.ObjectModel;
using Scantech.Infrastructure.Models.Registers;

namespace Scantech.Infrastructure.Models
{
    public class ECUModel
    {
        string ECUID { get; set; }
        Collection<IRegisterModel> Registers { get; set; }
        Collection<int> FaultCodes { get; set; }
    }
}
