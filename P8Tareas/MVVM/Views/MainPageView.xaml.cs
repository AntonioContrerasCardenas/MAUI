using P8Tareas.MVVM.Models;
using P8Tareas.MVVM.ViewModels;
using System.Collections.ObjectModel;

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

        if (sender is CheckBox checkBox && checkBox.BindingContext is Tasks tarea)
        {
            tarea.EstaCompletada = checkBox.IsChecked;

            var categoria = viewModel.Categorias.FirstOrDefault(c => c.Tareas.Contains(tarea));
            if (categoria != null)
            {
                categoria.Tareas = new ObservableCollection<Tasks>(categoria.Tareas);
            }
        }
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