using System.Globalization;

namespace MVVMDem.MVVM.Convert
{
    internal class BoolConvert : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var answer = value.ToString();
            if (answer == "yes") return true;
            return false;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var boolean = (bool)value;

            if (boolean) return "yes";
            return "no";
        }
    }
}
