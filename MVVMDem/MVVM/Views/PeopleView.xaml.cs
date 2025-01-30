using MVVMDem.MVVM.ViewModels;

namespace MVVMDem.MVVM.Views;

public partial class PeopleView : ContentPage
{
    public PeopleView()
    {
        InitializeComponent();

        BindingContext = new PeopleViewModel();
    }
}