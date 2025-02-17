using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace MascotasApp2.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]
    public class Animal
    {
        public int Id { get; set; }
        public bool IsAdopted { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Raza { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
    }
}
