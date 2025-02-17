using MascotasApp2.MVVM.Model;
using MascotasApp2.MVVM.ViewModel;

namespace MascotasApp2.MVVM.View;

public partial class NewPage1 : ContentPage
{
	public AnimalViewModel AnimalViewModel { get; set; }

	public NewPage1()
	{
		InitializeComponent();
		AnimalViewModel = new AnimalViewModel();
		BindingContext = AnimalViewModel;
	}

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		if (e.CurrentSelection.Count == 0) return;

		var animal = e.CurrentSelection[0] as Animal;

		if (animal.IsAdopted)
		{
			DisplayAlert("adoptado", "Animal ya adoptado", "Cerrar");
			return;
		}

		await Navigation.PushAsync(new NewPage2(AnimalViewModel, animal));


		((CollectionView)sender).SelectedItem = null;
    }
}