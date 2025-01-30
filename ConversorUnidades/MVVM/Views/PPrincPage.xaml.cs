using ConversorUnidades.MVVM.ViewModels;

namespace ConversorUnidades.MVVM.Views;

public partial class PPrincPage : ContentPage
{
    public PPrincPage()
    {
        InitializeComponent();
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is Grid grid)
        {
            string conversionType = grid.BindingContext as string;
            var convertView = new ConversionView
            {
                BindingContext = new ConversionViewModel(conversionType)
            };



            await Navigation.PushAsync(convertView);
        }


    }
}