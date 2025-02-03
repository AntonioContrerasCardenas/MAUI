using PropertyChanged;
using System.Collections.ObjectModel;

namespace P8Tareas.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Categories
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Lista de tareas dentro de la categoría
        public ObservableCollection<Tasks> Tareas { get; set; } = new ObservableCollection<Tasks>();

        public bool IsSelected { get; set; }

        //public double PorcentajeCompletadas =>
        //Tareas.Count == 0 ? 0 : (double)Tareas.Count(t => t.EstaCompletada);

        public double PorcentajeCompletadas =>
    Tareas.Count == 0 ? 0 : (double)Tareas.Count(t => t.EstaCompletada) / Tareas.Count;
    }
}
