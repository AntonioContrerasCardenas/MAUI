using PropertyChanged;

namespace DataBinding.Models
{
    [AddINotifyPropertyChangedInterface]
    internal class Person
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

    }
}
