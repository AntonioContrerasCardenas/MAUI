using P5IMC2.MVVM.Views;

namespace P5IMC2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new IMCView();
        }
    }
}
