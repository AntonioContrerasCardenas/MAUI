using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MascotasApp2.MVVM.Model;
using PropertyChanged;

namespace MascotasApp2.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class AnimalViewModel2
    {

        public Animal CurrentAnimal { get; set; }
        public AnimalViewModel ParentViewModel { get; set; }

        public ICommand AdoptAnimal { get; set; }


        public AnimalViewModel2(Animal a, AnimalViewModel b)
        {
            this.CurrentAnimal = a;
            this.ParentViewModel = b;
            AdoptAnimal = new Command(() =>
            {
            this.ParentViewModel.UpdateAnimals();
                CurrentAnimal.IsAdopted = true;
            });

        }
    }
}
