using PropertyChanged;
using System.Collections.ObjectModel;
using System.Windows.Input;
using UnitsNet;

namespace ConversorUnidades.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ConversionViewModel
    {

        public string QuantityName { get; set; }
        public ObservableCollection<string> FromMedidas { get; set; }
        public ObservableCollection<string> ToMedidas { get; set; }

        public string SelectedMedidasTo { get; set; }
        public string SelectedMedidasFrom { get; set; }
        public double ValorAConvertir { get; set; } = 1;
        public double Resultado { get; set; } = 1;

        public ConversionViewModel() { }

        public ConversionViewModel(String conversionType)
        {
            this.QuantityName = conversionType;
            this.FromMedidas = CargaMedidas();
            this.ToMedidas = CargaMedidas();
            this.SelectedMedidasFrom = FromMedidas.FirstOrDefault();
            this.SelectedMedidasTo = ToMedidas.Skip(1).FirstOrDefault();
            CalculateResult();
            ChangeCommand = new Command(() => CalculateResult());
        }

        public ICommand ChangeCommand { get; }

        //public ICommand ReturnCommand()
        //{
        //    return new Command(() => CalculateResult());
        //}

        public void CalculateResult()
        {
            Resultado = UnitConverter.ConvertByName(ValorAConvertir, QuantityName, SelectedMedidasFrom, SelectedMedidasTo);
            Console.WriteLine($"Calculando: {ValorAConvertir} {SelectedMedidasFrom} a {SelectedMedidasTo}");
        }

        private ObservableCollection<string> CargaMedidas()
        {
            var types = Quantity.Infos.FirstOrDefault(x => x.Name == QuantityName).UnitInfos.Select(u => u.Name).ToList();
            return new ObservableCollection<string>(types);
        }
    }
}
