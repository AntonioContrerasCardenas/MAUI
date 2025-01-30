namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var navPage = new NavigationPage(new MainPage());

            //navPage.BackgroundColor = Colors.LemonChiffon;

            //MainPage = navPage;

            MainPage = new ContentPageDemo();
        }
    }
}
