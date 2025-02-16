using RESTDemo8.MVVM.View;

namespace RESTDemo8
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new userView();
        }
    }
}
