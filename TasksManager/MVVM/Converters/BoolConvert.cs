using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksManager.MVVM.Converters
{
    public class BoolConvert : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var a = (bool)value;
            return a ? "Completada": "No completada";
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var b = (string)value;
            return b == "Completada" ? true : false;
        }
    }
}
