using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotaApp.MVVM.Model
{
    public class Animal
    {
        public int Id {  get; set; }
        public bool IsAdopted { get; set; }
        public string ImgAnimal { get; set; }
        public string Name { get; set; }
        public string  Raza { get; set; }
    }
}
