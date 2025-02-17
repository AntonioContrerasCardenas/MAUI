using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace TasksManager.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]
    public class TaskItem
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
    }
}
