using P5IMC2.MVVM.Models;

namespace P5IMC2.MVVM.ViewModels
{
    public class IMCViewModel
    {
        public IMCModel IMCModel { get; set; }

        public IMCViewModel()
        {
            IMCModel = new IMCModel
            {
                Altura = 180,
                Peso = 73,
            };
        }

    }
}
