using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace MascotaApp.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]
    public class Animal
    {
        public int Id {  get; set; }
        public bool IsAdopted { get; set; }
        public string ImgAnimal { get; set; }
        public string Name { get; set; }
        public string  Raza { get; set; }
    }
}
