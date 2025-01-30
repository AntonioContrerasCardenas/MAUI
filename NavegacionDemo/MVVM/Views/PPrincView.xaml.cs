using NavegacionDemo.MVVM.ViewModels;

namespace NavegacionDemo.MVVM.Views;

public partial class PPrincView : ContentPage
{
    private PPrincViewModel _princViewModel;
    private string dato;

    public PPrincView()
    {
        InitializeComponent();
        _princViewModel = new PPrincViewModel();
        BindingContext = _princViewModel;
    }

    //private void Button_Clicked(object sender, EventArgs e)
    //{
    //    Navigation.PushAsync(new SpagView(_princViewModel));
    //}

    private void Button_Clicked(object sender, EventArgs e)
    {
        dato = etiqueta.Text;
        Navigation.PushAsync(new SpagView(dato));
    }
}