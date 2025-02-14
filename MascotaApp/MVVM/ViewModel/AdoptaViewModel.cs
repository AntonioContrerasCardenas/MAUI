using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MascotaApp.MVVM.Model;
using MascotaApp.MVVM.ViewModel;
using PropertyChanged;

namespace MascotaApp.MVVM.View
{
    [AddINotifyPropertyChangedInterface]
    class AdoptaViewModel
    {
        public Animal AnimalSelected { get; set; }
        public ICommand AdoptCommand { get; set; }
        private AnimalViewModel AnimalViewModel { get; }

        public AdoptaViewModel(Animal animalSelected)
        {
            AnimalSelected = animalSelected;

            AdoptCommand = new Command(() =>
            {
                AnimalSelected.IsAdopted = true;
                Application.Current.MainPage.DisplayAlert("AdoptaApp", "Este animal ya esta adoptado", "Cancelar");
            });
        }

        //public AdoptaViewModel(Animal animalSelected, AnimalViewModel animalViewModel)
        //{
        //    AnimalViewModel = animalViewModel;
        //    AnimalSelected = animalSelected;

        //    AdoptCommand = new Command(() =>
        //    {
        //        AnimalSelected.IsAdopted = true;
        //        AnimalViewModel.UpdateAnimal(AnimalSelected);
        //        Application.Current.MainPage.DisplayAlert("AdoptaApp", "Este animal ya esta adoptado", "Cancelar");
        //    });
        //}
    }
}
