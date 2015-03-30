
namespace Scantech.Infrastructure.Models.Registers
{
    class DigitalInvertedRegisterModel: DigitalRegisterModel
    {
        bool IsInverted
        {
            get
            {
                return true;
            }
        }
    }
}
