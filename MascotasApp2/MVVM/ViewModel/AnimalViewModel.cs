using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MascotasApp2.MVVM.Model;
using PropertyChanged;

namespace MascotasApp2.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class AnimalViewModel
    {
        public ObservableCollection<Animal> Animals { get; set; }

        public AnimalViewModel()
        {
            Animals = new ObservableCollection<Animal>
            {
             new Animal { Id = 1, Name = "Firulais", Raza = "Pastor Aleman", IsAdopted = true, Image="cat.png" },
             new Animal { Id = 2, Name = "Rex", Raza = "Doberman", IsAdopted = false, Image="dotnet_bot.png" },
             new Animal { Id = 3, Name = "Boby", Raza = "Pitbull", IsAdopted = true, Image="pet1.png" },
             new Animal { Id = 4, Name = "Toby", Raza = "Bulldog", IsAdopted = false, Image="pet2.png" },
            };
        }

        public void UpdateAnimals()
        {
            var temp = new ObservableCollection<Animal>(Animals);

            Animals.Clear();

            foreach (var animal in temp)
            {
                Animals.Add(animal);
            }
        }
    }
}
