using DataBinding.Models;

namespace DataBinding
{
    public partial class MainPage : ContentPage
    {
        Person person = new Person();
        public MainPage()
        {
            InitializeComponent();

            person.Nombre = "Juan";
            person.Telefono = "Alguno";
            person.Direccion = "Larga";

            BindingContext = person;
        }

        private void New_Persona_Clicked(object sender, EventArgs e)
        {
            person.Nombre = "Antonio";
            person.Telefono = "6034";
            person.Direccion = "Silla";

        }
    }

}
