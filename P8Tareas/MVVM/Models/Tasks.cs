namespace P8Tareas.MVVM.Models
{
    public class Tasks
    {
        public string NameTask { get; set; }
        public bool IsCompleted { get; set; }

        public Tasks(string nameTask, bool isCompleted)
        {
            NameTask = nameTask;
            IsCompleted = isCompleted;
        }

        public Tasks() { }
    }
}
