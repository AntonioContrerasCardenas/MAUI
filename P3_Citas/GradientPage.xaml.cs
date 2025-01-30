namespace P3_Citas;

public partial class GradientPage : ContentPage
{
    public GradientPage()
    {
        InitializeComponent();
        SetLineaRandom();
    }

    private async void SetLineaRandom()
    {
        var linea = await GetLineaRandom();
        LabelCitas.Text = linea;
        ChangeGradient();
    }

    private void ChangeGradient()
    {
        var random = new Random();
        YellowGradient.Offset = random.NextSingle();
        RedGradient.Offset = random.NextSingle();
        BlueGradient.Offset = random.NextSingle();
        GreenGradient.Offset = random.NextSingle();
    }


    private void BtnChangeCita_Clicked(object sender, EventArgs e)
    {
        SetLineaRandom();
    }

    async Task<string> GetLineaRandom()
    {
        try
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("citas.txt");
            using var reader = new StreamReader(stream);

            var lineas = new List<string>();
            string linea;

            while ((linea = await reader.ReadLineAsync()) != null)
            {
                lineas.Add(linea);
            }


            if (lineas.Count > 0)
            {
                var random = new Random();
                return lineas[random.Next(lineas.Count)];
            }

            return "El fichero esta vacio";
        }
        catch (Exception ex)
        {
            return "El fichero esta vacio";
        }
    }
}