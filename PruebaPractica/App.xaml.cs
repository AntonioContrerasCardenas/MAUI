using PruebaPractica.MVVM.Views;

namespace PruebaPractica
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPageView();

            //Display alert: Application.Current.mainpage.displayalert("Title","Mensaje","Ok")
        }
    }
}
