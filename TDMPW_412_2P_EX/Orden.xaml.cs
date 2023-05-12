namespace TDMPW_412_2P_EX;


public partial class Orden : ContentPage
{
    public producto productoSeleccionado;
    public producto anteriorProductoSeleccionado;
    public static producto chocolate = new producto
    {
        precio = 102.15,
        calorias = 193,
        tamaño = "Mediano",
        imagen="chocolate.png",
        tipo="Chocolate",
        nombre="Chocolate caliente"

    };

    public static producto cheesecake = new producto
    {
        precio= 86.89,
        calorias = 392,
        tamaño= "Chico",
        imagen= "cheesecakeroulet.png",
        tipo="Cheesecake",
        nombre= "Cheesecake Roulet"
    };

    public static producto macchiato = new producto
    {
        precio = 88.85,
        calorias = 250,
        tamaño = "Grande",
        imagen = "macchiato.jpg",
        tipo = "Macchiato",
        nombre = "Caramel Macchiato"
    };

    public static producto croissant = new producto
    {
        precio = 54.00,
        calorias = 250,
        tamaño = "Mediano",
        imagen = "croissant.jpg",
        tipo = "Croissant",
        nombre = "Croissant Francés"
    };


    public producto[] productos = { chocolate, cheesecake, macchiato, croissant};

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
        lblRevisarCantidad.Text = $" <      Revisar pedido ({cantidad})";
        lblTotal.Text = $"Total................................${calculateTotal(cantidad,precio):F2}";
    }
    private void Producto1_Tapped(object sender, EventArgs e)
    {
        getSelectedProduct();
        swapProducts(Producto1.Tipo);
        Producto1.Tipo = anteriorProductoSeleccionado.tipo;
        lblNombreProducto1.Text = anteriorProductoSeleccionado.nombre;
        imgProducto1.Source = anteriorProductoSeleccionado.imagen;
    }
    private void Producto2_Tapped(object sender, EventArgs e)
    {
        getSelectedProduct();
        swapProducts(Producto2.Tipo);
        Producto2.Tipo = anteriorProductoSeleccionado.tipo;
        lblNombreProducto2.Text = anteriorProductoSeleccionado.nombre;
        imgProducto2.Source = anteriorProductoSeleccionado.imagen;
    }
    private void Producto3_Tapped(object sender, EventArgs e)
    {
        getSelectedProduct();
        swapProducts(Producto3.Tipo);
        Producto3.Tipo = anteriorProductoSeleccionado.tipo;
        lblNombreProducto3.Text = anteriorProductoSeleccionado.nombre;
        imgProducto3.Source = anteriorProductoSeleccionado.imagen;
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
        lblTotal.Text = $"Total................................${nuevoProductoSeleccionado.precio:F2}";
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
                { productoSeleccionado = macchiato; }
                break;
            case "Croissant":
                { productoSeleccionado = croissant; }
                break;
            default:
                break;
        }
    }

    public double calculateTotal(int cantidad, double precio) {
        var total = cantidad * precio; return total;
    }
}
