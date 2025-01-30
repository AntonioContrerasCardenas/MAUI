using System.Windows.Input;

namespace MVVMDem.MVVM.ViewModels
{
    internal class CommandViewModel
    {
        public ICommand ClickComand { get; }
        public ICommand ClickComand1 { get; }

        public CommandViewModel()
        {
            ClickComand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Title", "Btn clicked", "OK");
            });

            ClickComand1 = new Command((s) =>
            {
                App.Current.MainPage.DisplayAlert("Title", s.ToString(), "OK");
            });
        }

    }
}
