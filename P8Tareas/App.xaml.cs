using P8Tareas.MVVM.Views;

namespace P8Tareas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPageView());
        }
    }
}
