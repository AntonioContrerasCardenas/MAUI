using Calculadora.MVVM.ModelsView;

namespace Calculadora.MVVM.Views;

public partial class CalculadoraView : ContentPage
{
	public CalculadoraView()
	{
		InitializeComponent();
		BindingContext = new CalculadoraViewModel();
	}
}