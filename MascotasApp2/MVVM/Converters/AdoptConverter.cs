using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotasApp2.MVVM.Converters
{
    public class AdoptConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var valu = (bool)value;
            return valu ? "Adoptado" : "Adoptame";
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var valu = (string)value;
            return valu == "Adoptado" ? true : false;
        }
    }
}
