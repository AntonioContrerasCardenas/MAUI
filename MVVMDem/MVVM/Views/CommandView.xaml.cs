using MVVMDem.MVVM.ViewModels;

namespace MVVMDem.MVVM.Views;

public partial class CommandView : ContentPage
{
    public CommandView()
    {
        InitializeComponent();

        BindingContext = new CommandViewModel();
    }
}