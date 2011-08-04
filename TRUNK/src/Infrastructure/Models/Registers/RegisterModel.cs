using System;
using System.ComponentModel;

namespace Scantech.Infrastructure.Models.Registers
{
    abstract class RegisterModel : IRegisterModel, IDataErrorInfo
    {
        #region Register Constants

        const int NameLengthLimit = 50;

        #endregion

        #region IRegisterModel Members

        public byte Address { get; set; }
        public string Name { get; set; }
        public Enum Unit { get; set; } // Overloaded in the respective Registers
        public object Value { get; set; } // Overloaded in the respective Registers

        #endregion

        #region IDataErrorInfo Members

        public string Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string this[string columnName]
        {
            get
            {
                var errorMessage = string.Empty;

                if (columnName == "Name")
                {
                    if (Name.Length > NameLengthLimit)
                    {
                        errorMessage = string.Format("The name of this register is {0} above the {1} character limit.", (Name.Length - NameLengthLimit).ToString(), NameLengthLimit);
                    }
                }

                return errorMessage;
            }
        }

        #endregion
    }
}
