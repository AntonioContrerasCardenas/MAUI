namespace MauiApp1;

public partial class ContentPageDemo : ContentPage
{
    public ContentPageDemo()
    {
        InitializeComponent();
    }

    private void onValueSliderChanged(object sender, ValueChangedEventArgs e)
    {
        int red = (int)RedSlider.Value;
        int blue = (int)BlueSlider.Value;
        int green = (int)GreenSlider.Value;

        Color selectedColor = Color.FromRgb(red, green, blue);

        MainPage.BackgroundColor = selectedColor;

        HexLabel.Text = $"HEX Value: {selectedColor.ToHex()}";
    }

    private void RandomBtn_Clicked(object sender, EventArgs e)
    {
        Random random = new Random();
        RedSlider.Value = random.Next(0, 256);
        BlueSlider.Value = random.Next(0, 256);
        GreenSlider.Value = random.Next(0, 256);
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Clipboard.SetTextAsync(HexLabel.Text.Replace("HEX Value: ", ""));
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        Clipboard.SetTextAsync(HexLabel.Text.Replace("HEX Value: ", ""));
    }

    private void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        Clipboard.SetTextAsync(HexLabel.Text.Replace("HEX Value: ", ""));
    }
}