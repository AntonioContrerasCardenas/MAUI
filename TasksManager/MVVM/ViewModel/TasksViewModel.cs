using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TasksManager.MVVM.Model;

namespace TasksManager.MVVM.ViewModel
{
    public class TasksViewModel
    {
        public ObservableCollection<TaskItem> Tareas { get; set; }
        public ICommand NavigateToDetailCommand { get; }

        public TasksViewModel()
        {

            //NavigateToDetailCommand = new Command<TaskItem>(async (task) =>
            //{
            //    if (task != null)
            //    {
            //        // Navegamos a TaskDetailPage, pasando la tarea seleccionada y la instancia actual de TaskViewModel
            //        await Application.Current.MainPage.Navigation.PushAsync(new TaskDetailPage(task, this));
            //    }
            //});
            Tareas = new ObservableCollection<TaskItem>
            {
                new TaskItem
                {
                    Descripcion = "Descripcion 1",
                    Id = 1,
                    IsCompleted = true,
                    Titulo = "Titulo 1"
                },
                new TaskItem
                {
                    Descripcion = "Descripcion 2",
                    Id = 2,
                    IsCompleted = false,
                    Titulo = "Titulo 2"
                },
                new TaskItem
                {
                    Descripcion = "Descripcion 3",
                    Id = 3,
                    IsCompleted = false,
                    Titulo = "Titulo 3"
                },
                new TaskItem
                {
                    Descripcion = "Descripcion 4",
                    Id = 4,
                    IsCompleted = false,
                    Titulo = "Titulo 4"
                }
            };

        }
    }
}
