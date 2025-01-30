using MVVMDem.MVVM.Models;

namespace MVVMDem.MVVM.ViewModels
{
    internal class PeopleViewModel
    {
        public List<Person> People { get; set; } = new List<Person>();

        public PeopleViewModel()
        {
            People.Add(new Person() { Name = "John", Age = 42, Married = "yes", BirthDate = new DateTime(2012, 12, 12), Weight = 80, LunchTime = new TimeSpan(12, 30, 0) });
            People.Add(new Person() { Name = "Alice", Age = 30, Married = "no", BirthDate = new DateTime(1993, 7, 15), Weight = 60, LunchTime = new TimeSpan(13, 0, 0) });
            People.Add(new Person() { Name = "Bob", Age = 50, Married = "yes", BirthDate = new DateTime(1973, 5, 20), Weight = 90, LunchTime = new TimeSpan(12, 0, 0) });
            People.Add(new Person() { Name = "Sophia", Age = 25, Married = "no", BirthDate = new DateTime(1998, 2, 28), Weight = 55, LunchTime = new TimeSpan(14, 0, 0) });
            People.Add(new Person() { Name = "Mike", Age = 35, Married = "yes", BirthDate = new DateTime(1988, 10, 10), Weight = 75, LunchTime = new TimeSpan(12, 45, 0) });
        }
    }
}
