using MascotasApp2.MVVM.Model;
using MascotasApp2.MVVM.ViewModel;

namespace MascotasApp2.MVVM.View;

public partial class NewPage2 : ContentPage
{

    public NewPage2(AnimalViewModel animalViewModel, Animal animal)
    {
        InitializeComponent();
        BindingContext = new AnimalViewModel2(animal, animalViewModel);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}