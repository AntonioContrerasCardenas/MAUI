using Dangl.Calculator;
using PropertyChanged;
using System.Windows.Input;

namespace Calculadora.MVVM.ModelsView
{
    [AddINotifyPropertyChangedInterface]
    public class CalculadoraViewModel
    {
        public string Formula { get; set; }
        public string Result { get; set; } = "0";

        public ICommand AddOperation => new Command((number) => { Formula += number; });

        public ICommand ResetCommand => new Command(() => { Result = "0"; Formula = ""; });

        public ICommand DeleteLastCommand => new Command(() =>
        {
            if (Formula.Length < 0)
                return;

            Formula = Formula.Substring(0, Formula.Length - 1);
        });

        public ICommand CalculateResultOperation => new Command(() =>
        {
            if (Formula.Length < 0)
                return;

            Result = Calculator.Calculate(Formula).Result.ToString();
        });
    }
}
