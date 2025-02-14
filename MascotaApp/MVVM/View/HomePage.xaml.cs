namespace MascotaApp.MVVM.ViewModel;

using System.Runtime.CompilerServices;
using System.Windows.Input;
using MascotaApp.MVVM.Model;
using Microsoft.Maui.Controls.Platform;
using View;
public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new AnimalViewModel();
	}
    public async void MuestraAdoptame()
	{
		await Navigation.PushAsync(new AdoptaView());
	}

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedAnimal = e.CurrentSelection[0] as Animal;

		if (selectedAnimal == null) return;

		if (selectedAnimal.IsAdopted)
		{
			DisplayAlert("AdoptaApp","Este animal ya esta adoptado","Cancelar");
			return;
		}

		await Navigation.PushAsync(new AdoptaView());
    }
}