using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MascotaApp.MVVM.Model;

namespace MascotaApp.MVVM.ViewModel
{
    public class AnimalViewModel
    {

        public ObservableCollection<Animal> Animals { get; set; }

        public AnimalViewModel() { 
        
            Animals = new ObservableCollection<Animal>()
            {
                new Animal
                {
                    ImgAnimal = "cat.png",
                    IsAdopted = true,
                    Name="Gatardo",
                    Raza = "Persa"
                },
                new Animal
                {
                    ImgAnimal = "pet1.png",
                    IsAdopted = false,
                    Name="Perro1",
                    Raza = "York"
                },
                new Animal
                {
                    ImgAnimal = "pet2.png",
                    IsAdopted = false,
                    Name="Perro1",
                    Raza = "Pastor aleman"
                }
            };
        }

    }
}
