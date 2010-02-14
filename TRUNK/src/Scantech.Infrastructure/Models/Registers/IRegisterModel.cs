using System;
namespace Scantech.Infrastructure.Models.Registers
{
    interface IRegisterModel
    {
        #region Basic Register Properties

        byte Address { get; set; }
        string Name { get; set; }
        Enum Unit { get; set; }
        object Value { get; set; }

        #endregion
    }
}
