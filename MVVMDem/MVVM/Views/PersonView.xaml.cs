using MVVMDem.MVVM.ViewModels;

namespace MVVMDem.MVVM.Views;

public partial class PersonView : ContentPage
{
    public PersonView()
    {
        InitializeComponent();
        BindingContext = new PersonViewModel();
    }
}