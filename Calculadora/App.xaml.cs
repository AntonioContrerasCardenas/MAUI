using Calculadora.MVVM.Views;

namespace Calculadora
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalculadoraView();
        }
    }
}
