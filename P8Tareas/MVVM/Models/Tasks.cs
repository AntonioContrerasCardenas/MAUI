using PropertyChanged;

namespace P8Tareas.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Tasks
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool EstaCompletada { get; set; }
    }
}
