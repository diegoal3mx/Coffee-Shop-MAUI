namespace TDMPW_412_2P_EX;

public partial class Orden : ContentPage
{
	public Orden()
	{
		InitializeComponent();
	}

    private void stpCantidad_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var cantidad = (int)stpCantidad.Value;
        lblPrecio.Text = $"{cantidad} x $38.00";
       

    }
}