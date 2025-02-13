namespace MascotaApp.MVVM.ViewModel;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new AnimalViewModel();
	}
}