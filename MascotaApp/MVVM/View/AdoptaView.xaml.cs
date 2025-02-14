using MascotaApp.MVVM.Model;
using MascotaApp.MVVM.ViewModel;

namespace MascotaApp.MVVM.View;

public partial class AdoptaView : ContentPage
{
    public Animal Animal { get; set; }
    //   public AdoptaView(Animal animal, AnimalViewModel animalViewModel)
    //{
    //	InitializeComponent();
    //	BindingContext = new AdoptaViewModel(animal, animalViewModel);
    //}

    public AdoptaView(Animal animal)
    {
        InitializeComponent();
        BindingContext = new AdoptaViewModel(animal);
    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}