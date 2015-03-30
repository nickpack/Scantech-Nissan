using Scantech.Infrastructure.Properties;

namespace Scantech.Infrastructure.Models.Registers
{
    class DigitalRegisterModel : RegisterModel, IRegisterModel
    {
        #region Digital Register-Specific Enumerations

        public enum DigitalBitPosition
        {
            b0,
            b1,
            b2,
            b3,
            b4,
            b5,
            b6,
            b7
        }

        public enum DigitalUnits
        {
            OnOff,
            RichLean,
            NotApplicable
        }

        #endregion

        #region RegisterModel Overloaded Methods

        public new DigitalUnits Unit { get; set; }
        public new bool Value { get; set; }

        #endregion

        #region Digital Register-Specific Members

        public DigitalBitPosition BitPosition { get; set; }

        bool IsInverted
        {
            get
            {
                return false;
            }
        }

        public string ValueToString()
        {
            var valueToReturn = string.Empty;

            switch (Unit)
            {
                case DigitalUnits.OnOff:
                    valueToReturn = GetIt(this.Value, this.IsInverted, Resources.EN_ON, Resources.EN_OFF);
                    break;
                case DigitalUnits.RichLean:
                    valueToReturn = GetIt(this.Value, this.IsInverted, Resources.EN_RICH, Resources.EN_LEAN);
                    break;
                default:
                    valueToReturn = Resources.EN_NA;
                    break;
            }

            return valueToReturn;
        }

        private string GetIt(bool value, bool isInverted, string on, string off)
        {
            var valueToReturn = string.Empty;

            if (!isInverted)
            {
                if (value)
                {
                    valueToReturn = on;
                }
                else
                {
                    valueToReturn = off;
                }
            }
            else
            {
                if (value)
                {
                    valueToReturn = off;
                }
                else
                {
                    valueToReturn = on;
                }
            }

            return valueToReturn;
        }

        #endregion
    }
}
