using P8Tareas.MVVM.ViewModels;

namespace P8Tareas.MVVM.Views;

public partial class MainPageView : ContentPage
{
    public MainPageView()
    {
        InitializeComponent();
        BindingContext = new TasksViewModel();
    }
}