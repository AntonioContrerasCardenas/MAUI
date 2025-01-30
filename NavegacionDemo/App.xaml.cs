namespace NavegacionDemo;

using NavegacionDemo.MVVM.Views;

public partial class App : Application
{

    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new PPrincView());
    }
}
