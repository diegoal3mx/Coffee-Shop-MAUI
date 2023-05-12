namespace TDMPW_412_2P_EX;


public partial class Orden : ContentPage
{
    public producto productoSeleccionado;
    public producto anteriorProductoSeleccionado;
    public static producto chocolate = new producto
    {
        precio = 120.00,
        calorias = 123,
        tamaño = "mediano",
        imagen="bebidacaliente.jpg",
        tipo="Chocolate",
        nombre="Chocolate caliente"

    };

    public static producto cheesecake = new producto
    {
        precio= 86.89,
        calorias = 392,
        tamaño= "Chico",
        imagen= "cheesecake.jpg",
        tipo="Cheesecake",
        nombre= "Cheesecake Roulet"
    };

   public producto[] productos = { chocolate, cheesecake};

    public Orden()
	{
		InitializeComponent();
    }

    private void stpCantidad_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var cantidad = (int)stpCantidad.Value;
        getSelectedProduct();
        var precio = productoSeleccionado.precio;
        lblPrecio.Text = $"{cantidad} x ${precio:F2}";
        lblTotal.Text = $"Total____________________${calculateTotal(cantidad,precio):F2}";
    }
    private void Producto1_Tapped(object sender, EventArgs e)
    {
        getSelectedProduct();
        swapProducts(Producto1.Tipo);
        Producto1.Tipo = anteriorProductoSeleccionado.tipo;
        lblNombreProducto1.Text = anteriorProductoSeleccionado.nombre;
        imgProducto1.Source = anteriorProductoSeleccionado.imagen;
       
        
    }


    public void swapProducts(string tipo) {
        getSelectedProduct();
        anteriorProductoSeleccionado = productoSeleccionado;
        producto nuevoProductoSeleccionado = new producto();

        foreach (producto p in productos) {
            if (p.tipo == tipo) {
                nuevoProductoSeleccionado = p;
            }
        }

        lblNombreProductoSeleccionado.Text=nuevoProductoSeleccionado.nombre;
        lblCaloríasProductoSeleccionado.Text = $"{nuevoProductoSeleccionado.calorias} calorías";
        lblTamañoProductoSeleccionado.Text = nuevoProductoSeleccionado.tamaño;
        imgProductoSeleccionado.Source = nuevoProductoSeleccionado.imagen;
        stpCantidad.Value = 1;
        lblPrecio.Text = $"1 x ${nuevoProductoSeleccionado.precio:F2}";
        lblTotal.Text = $"Total____________________${nuevoProductoSeleccionado.precio:F2}";
        ProductoSeleccionado.Tipo= nuevoProductoSeleccionado.tipo;



    }

    public void getSelectedProduct() {
       
        switch (ProductoSeleccionado.Tipo)
        {
            case "Chocolate":
                { productoSeleccionado = chocolate; }
                break;
            case "Cheesecake":
                { productoSeleccionado = cheesecake; }
                break;
            case "Macchiato":
                { }
                break;
            case "Croissant":
                { }
                break;
            default:
                break;
        }
    }

    public double calculateTotal(int cantidad, double precio) {
        var total = cantidad * precio; return total;
    }
}
