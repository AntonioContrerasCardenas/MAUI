using PropertyChanged;

namespace P8Tareas.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    internal class Categories
    {
        public string CategoryName { get; set; }
        public Tasks Tasks { get; set; }

        public Categories()
        {

        }


    }
}
