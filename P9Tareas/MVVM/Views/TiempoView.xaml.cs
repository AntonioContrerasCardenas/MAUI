using P9Tareas.MVVM.ViewModels;

namespace P9Tareas.MVVM.Views;

public partial class TiempoView : ContentPage
{
	public TiempoView()
	{
		InitializeComponent();
		BindingContext = new TiempoViewModel();
	}
}