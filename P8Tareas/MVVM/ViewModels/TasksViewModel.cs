using P8Tareas.MVVM.Models;
using System.Collections.ObjectModel;

namespace P8Tareas.MVVM.ViewModels
{
    //[AddINotifyPropertyChangedInterface]
    public class TasksViewModel
    {
        public ObservableCollection<Categories> Categorias { get; set; }
        public ObservableCollection<Tasks> AllTareas { get; set; }

        public TasksViewModel()
        {
            Categorias = new ObservableCollection<Categories>
            {
                new Categories
                {
                    Id = 1, Nombre = "Curso .NET MAUI",
                    Tareas = new ObservableCollection<Tasks>
                    {
                       new Tasks {Id = 1, Nombre = "ASP .NEY en YOUTUBE", EstaCompletada = false},
                       new Tasks {Id = 2, Nombre = "Introduccion a .NET 9", EstaCompletada = false},

                    }
                },
                new Categories
                {
                    Id = 2, Nombre = "Tutoriales",
                    Tareas = new ObservableCollection<Tasks>
                    {
                       new Tasks {Id = 3, Nombre = "Tutorial MAUI", EstaCompletada = true},
                       new Tasks {Id = 4, Nombre = "Tutorial Angular", EstaCompletada = true},

                    }
                },

                new Categories
                {
                    Id = 3, Nombre = "Compras",
                    Tareas = new ObservableCollection<Tasks>
                    {
                       new Tasks {Id = 5, Nombre = "Mercadona", EstaCompletada = false},
                       new Tasks {Id = 6, Nombre = "LIDL", EstaCompletada = false},
                    }
                },
            };

            AllTareas = new ObservableCollection<Tasks>(
               Categorias.SelectMany(c => c.Tareas).ToList()
                );

        }

        public void UpdateAllTareas()
        {
            AllTareas.Clear();
            AllTareas = new ObservableCollection<Tasks>(
               Categorias.SelectMany(c => c.Tareas).ToList()
                );
        }
    }
}
