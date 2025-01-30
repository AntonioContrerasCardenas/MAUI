using MVVMDem.MVVM.Models;

namespace MVVMDem.MVVM.ViewModels
{
    internal class PersonViewModel
    {
        public Person Person { get; set; }

        public PersonViewModel()
        {
            Person = new Person
            {
                Name = "Hector",
                Age = 50,
                Married = "yes",
                BirthDate = new DateTime(2000, 08, 05),
                Weight = 100,
                LunchTime = new TimeSpan(10, 0, 0),
            };
        }
    }
}
