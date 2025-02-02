using P8Tareas.MVVM.ViewModels;

namespace P8Tareas.MVVM.Views;

public partial class MainPageView : ContentPage
{
    TasksViewModel viewModel = new TasksViewModel();

    public MainPageView()
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private void checkBoxCompletTaks_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        //viewModel.UpdateData();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var AddTaskView = new AddTasks
        {
            BindingContext = new AddTasksViewModel
            {
                Tasks = viewModel.AllTareas,
                Categories = viewModel.Categorias
            }
        };

        Navigation.PushAsync(AddTaskView);
    }
}