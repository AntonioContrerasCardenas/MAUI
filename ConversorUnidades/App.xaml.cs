using ConversorUnidades.MVVM.Views;

namespace ConversorUnidades;
public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new PPrincPage());
    }
}
