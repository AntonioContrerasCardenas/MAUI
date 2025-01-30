using MVVMDem.MVVM.Views;

namespace MVVMDem
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CommandView();
        }
    }
}
