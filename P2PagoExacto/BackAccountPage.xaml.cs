namespace P2PagoExacto;

public partial class BackAccountPage : ContentPage
{
    public int NumeroPersonasInt { get; set; } = 1;
    public double TotalCuentaPersona { get; set; } = 0.0;
    public double PropinasCuentaPersona { get; set; } = 0.0;
    public double SubtotalCuentaPersona { get; set; } = 0.0;
    public int Propina { get; set; } = 0;
    public double TotalCuenta { get; set; } = 0.0;

    public BackAccountPage()
    {
        InitializeComponent();
    }

    private void CalcularTotales()
    {
        double propinaTotal = (TotalCuenta * Propina) / 100;

        double SubtotalPorPersonaD = TotalCuenta / NumeroPersonasInt;
        double PropinaPorPersonaD = propinaTotal / NumeroPersonasInt;
        double TotalPersona = SubtotalPorPersonaD + PropinaPorPersonaD;

        TotalPorPersona.Text = $"{TotalPersona:0.00} €";
        SubtotalPorPersona.Text = $"{SubtotalPorPersonaD:0.00} €";
        PropinaPorPersona.Text = $"{PropinaPorPersonaD:0.00} €";
    }

    private void DecrementarBtn_Clicked(object sender, EventArgs e)
    {
        if (NumeroPersonasInt <= 1)
        {
            return;
        }

        NumeroPersonasInt--;
        NumeroPersonas.Text = NumeroPersonasInt.ToString();
        CalcularTotales();
    }

    private void IncrementarBtn_Clicked(object sender, EventArgs e)
    {
        NumeroPersonasInt++;
        NumeroPersonas.Text = NumeroPersonasInt.ToString();
        CalcularTotales();
    }

    private void OnPropinaBtnClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string propinaString = button.Text;
        Propina = int.Parse(propinaString.Replace("%", ""));
        SetPorcentajeText(Propina);
        CalcularTotales();
    }

    private void PropinaSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        int propina = (int)PropinaSlider.Value;
        Propina = propina;
        SetPorcentajeText(Propina);
        CalcularTotales();
    }

    private void Cuenta_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            TotalCuenta = double.Parse(Cuenta.Text.Replace(".", ","));
            CalcularTotales();
        }
        catch (Exception)
        {
            TotalCuenta = 0.0;
        }
    }

    private void SetPorcentajeText(int porcentaje)
    {
        PropinaLabel.Text = $"Propina: {porcentaje}%";
    }
}