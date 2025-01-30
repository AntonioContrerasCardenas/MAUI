using System.Globalization;

namespace PruebaPractica.MVVM.Convert
{
    public class ConvertEntregadoONo : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var isEntregado = (bool)value;
            return isEntregado ? "Justo a tiempo" : "Queda poco";
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var txtE = (string)value;
            return txtE == "Justo a tiempo" ? true : false;
        }
    }
}
