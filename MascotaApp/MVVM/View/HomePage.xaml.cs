namespace MascotaApp.MVVM.ViewModel;

using MascotaApp.MVVM.Model;
using View;
public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new AnimalViewModel();
	}

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count == 0) return;

        var selectedAnimal = e.CurrentSelection[0] as Animal;

        if (selectedAnimal == null) return;

        if (selectedAnimal.IsAdopted)
        {
            DisplayAlert("AdoptaApp", "Este animal ya esta adoptado", "Cancelar");
            return;
        }

        await Navigation.PushAsync(new AdoptaView(selectedAnimal, BindingContext as AnimalViewModel));

        ((CollectionView)sender).SelectedItem = null;

    }
}