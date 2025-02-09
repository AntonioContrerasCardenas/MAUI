using P9Tareas.MVVM.Views;

namespace P9Tareas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new TiempoView());
        }
    }
}