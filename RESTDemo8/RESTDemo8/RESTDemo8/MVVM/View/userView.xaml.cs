using RESTDemo8.MVVM.ViewModel;

namespace RESTDemo8.MVVM.View;

public partial class userView : ContentPage
{
	public userView()
	{
		InitializeComponent();

		BindingContext = new userViewModel();
	}
}