using NavegacionDemo.MVVM.ViewModels;

namespace NavegacionDemo.MVVM.Views;

public partial class SpagView : ContentPage
{
    public SpagView()
    {
        InitializeComponent();
    }

    public SpagView(PPrincViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    public SpagView(string dato)
    {
        InitializeComponent();
        BindingContext = new SPagViewModel();
    }
}