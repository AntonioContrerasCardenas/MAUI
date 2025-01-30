using System.Collections.ObjectModel;

namespace P8Tareas.MVVM.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Lista de tareas dentro de la categoría
        public ObservableCollection<Tasks> Tareas { get; set; } = new ObservableCollection<Tasks>();


    }
}
