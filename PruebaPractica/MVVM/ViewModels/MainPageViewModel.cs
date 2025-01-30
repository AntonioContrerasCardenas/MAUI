using PropertyChanged;
using System.Windows.Input;

namespace PruebaPractica.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageViewModel
    {

        public string NumeroTelefono { get; set; } = "Llama al 123354454";
        public string CorreoElectronico { get; set; } = "Mandar correo a adomicilio@adomicilio.com";
        public int Valoracion { get; set; } = 4;

        public bool isEntregado { get; set; } = false;
        //public ICommand DisplayAlert = new Command((mensaje) => { Application.Current.MainPage.DisplayAlert("A domicilio", mensaje as string, "Ok"); });


        public ICommand DisplayAlert { get; set; }


        //public ICommand DisplayAlertValoracion = new Command((mensaje) => Application.Current.MainPage.DisplayAlert("A domicilio", "Gracias por su valoracion " + mensaje, "Ok"));
        public ICommand DisplayAlertValoracion { get; set; }

        public MainPageViewModel()
        {
            DisplayAlert = new Command((mensaje) => { Application.Current.MainPage.DisplayAlert("A domicilio", mensaje as string, "Ok"); });
            DisplayAlertValoracion = new Command((mensaje) =>
            {
                isEntregado = true;
                Application.Current.MainPage.DisplayAlert("A domicilio", "Gracias por su valoracion de un " + mensaje, "Ok");
            });
        }

    }
}
