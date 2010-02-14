using System;
using System.ComponentModel;

namespace Scantech.Infrastructure.Models.Registers
{
    class AnalogRegisterModel : RegisterModel, IRegisterModel
    {
        public enum AnalogUnits
        {
            RevolutionsPerMinute,
            MilliVolt,
            MilliSecond,
            Celsius,
            Percentage,
            Alpha,
            NotApplicable
        }

        public new AnalogUnits Unit { get; set; }
    }
}
