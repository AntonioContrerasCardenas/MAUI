using MascotasApp2.MVVM.View;

namespace MascotasApp2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new NewPage1()));
        }
    }
}