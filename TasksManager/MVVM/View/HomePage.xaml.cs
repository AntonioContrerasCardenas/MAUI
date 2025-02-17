using TasksManager.MVVM.ViewModel;

namespace TasksManager.MVVM.View;

public partial class HomePage : ContentPage
{
	public TasksViewModel TasksViewModel = new TasksViewModel();
	public HomePage()
	{
		InitializeComponent();
		BindingContext = TasksViewModel;
	}
}