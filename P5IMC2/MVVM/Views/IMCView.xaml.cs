using P5IMC2.MVVM.ViewModels;

namespace P5IMC2.MVVM.Views;

public partial class IMCView : ContentPage
{
    private IMCViewModel mcViewModel;

    public IMCView()
    {
        InitializeComponent();
        mcViewModel = new IMCViewModel();
        BindingContext = mcViewModel;

        UpdateIMC();
    }

    private void PesoPointer_ValueChanged(object sender, Syncfusion.Maui.Gauges.ValueChangedEventArgs e)
    {
        var peso = PesoPointer.Value;
        mcViewModel.IMCModel.Peso = peso;

        UpdateIMC();
    }

    private void HeightPotiner_ValueChanged(object sender, Syncfusion.Maui.Gauges.ValueChangedEventArgs e)
    {
        var altura = HeightPotiner.Value;
        mcViewModel.IMCModel.Altura = altura;

        UpdateIMC();
    }

    private void UpdateIMC()
    {
        var resultado = mcViewModel.IMCModel.Resultado();
        var clasificacion = mcViewModel.IMCModel.Clasificacion;

        pointer.Value = resultado;
        label_clasificacion.Text = clasificacion.ToString();
    }
}
