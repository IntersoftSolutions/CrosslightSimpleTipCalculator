using System;
using Windows.UI.Xaml.Data;

namespace SimpleTipCalculator.WinRT.Converters
{
    public class NativeTypeConverter : IValueConverter
    {
        #region Methods

        private string FormatString(object value, string format)
        {
            if (value != null && string.IsNullOrEmpty(format))
                return value.ToString();

            return string.Format(format, value);
        }

        #endregion

        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            // No format provided.
            if (parameter == null)
                return value;

            string[] parameters = parameter.ToString().Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
            string format = (parameters.Length > 1 ? parameters[1] : "");

            return this.FormatString(value, format);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            // WinRT bug: targetType always return object instead of the desired target type

            if (!string.IsNullOrEmpty(value.ToString()))
            {
                string[] parameters = parameter.ToString().Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
                string type = parameters[0];

                if (type == "Decimal")
                    return decimal.Parse(value.ToString());
                if (type == "Int")
                    return int.Parse(value.ToString());
                if (type == "Double")
                    return double.Parse(value.ToString());
                if (type == "Float")
                    return float.Parse(value.ToString());
                if (type == "DateTime")
                    return DateTime.Parse(value.ToString());

                return value;
            }
            return null;
        }

        #endregion
    }
}