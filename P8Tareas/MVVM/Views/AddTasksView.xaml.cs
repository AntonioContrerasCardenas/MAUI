using P8Tareas.MVVM.Models;
using P8Tareas.MVVM.ViewModels;

namespace P8Tareas.MVVM.Views;

public partial class AddTasks : ContentPage
{
    public AddTasks()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var viewNodel = BindingContext as AddTasksViewModel;

        var categorySelected = viewNodel.Categories.Where(c => c.IsSelected == true).FirstOrDefault();

        var tasksValidate = viewNodel.Task;

        //TODO: Terminar el agregado de las categorias
        if (categorySelected != null && tasksValidate != null)
        {
            var tasksValidateReplace = viewNodel.Task.Replace(" ", "");

            if (!(tasksValidateReplace.Length > 0))
            {
                await DisplayAlert("Error", "Seleccione una categoria y escribe un nombre de la tarea", "Ok");
                return;
            }

            var newTask = new Tasks
            {
                Id = viewNodel.Tasks.Count + 1,
                Nombre = viewNodel.Task.Trim(),
                EstaCompletada = false
            };
            viewNodel.Tasks.Add(newTask);
            categorySelected.Tareas.Add(newTask);
            await Navigation.PopAsync();
        }
        else
        {
            await DisplayAlert("Error", "Seleccione una categoria y escribe un nombre de la tarea", "Ok");
        }
    }
}