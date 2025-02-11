using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P8Tareas.MVVM.Models;
using PropertyChanged;

namespace P8Tareas.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class AddTasksViewModel
    {

        public string Task {  get; set; }

        public ObservableCollection<Tasks> Tasks { get; set; }
        public ObservableCollection<Categories> Categories { get; set; }

    }
}
