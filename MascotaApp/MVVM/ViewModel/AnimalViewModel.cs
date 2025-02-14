using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MascotaApp.MVVM.Model;
using MascotaApp.MVVM.View;

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
                    Id = 1,
                    ImgAnimal = "cat.png",
                    IsAdopted = true,
                    Name="Gatardo",
                    Raza = "Persa"
                },
                new Animal
                {
                    Id = 2,
                    ImgAnimal = "pet1.png",
                    IsAdopted = false,
                    Name="Perro1",
                    Raza = "York"
                },
                new Animal
                {
                    Id = 3,
                    ImgAnimal = "pet2.png",
                    IsAdopted = false,
                    Name="Perro1",
                    Raza = "Pastor aleman"
                }
            };
        }

    }
}
