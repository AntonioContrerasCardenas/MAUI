using PruebaPractica.MVVM.ViewModels;

namespace PruebaPractica.MVVM.Views;

public partial class MainPageView : ContentPage
{
    public MainPageView()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }
}