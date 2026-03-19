List<Venta> ventas = new List<Venta>();

Console.Write("Ingrese el número de ventas: ");
int n = int.Parse(Console.ReadLine());

Console.Clear();

for (int i = 0; i < n; i++)
{
    Venta v = new Venta();
    Console.WriteLine("Venta: " + (i + 1));

    Console.Write("Producto: "); v.Producto = Console.ReadLine();
    Console.Write("Precio: "); v.Precio = double.Parse(Console.ReadLine());
    Console.Write("Cantidad: "); v.Cantidad= int.Parse(Console.ReadLine());
    ventas.Add(v);
    Console.Clear();
}

double totalGeneral = 0;

Console.WriteLine("Ventas Registradas: ");
Console.WriteLine();

foreach (Venta v in ventas)
{
    v.MostrarVenta();
    totalGeneral += v.CalcularTotal();
}

Console.WriteLine("TOTAL GENERAL VENDIDO: " + totalGeneral);
class Venta
{
    public string Producto;
    public double Precio;
    public int Cantidad;

    public double CalcularSubtotal()
    {
        return Precio * Cantidad;
    }

    public double CalcularDescuento()
    {
        double subtotal = CalcularSubtotal();

        if (subtotal > 100)
            return subtotal * 0.10;
        else if (subtotal > 50)
            return subtotal * 0.05;
        else
            return 0;
    }

    public double CalcularTotal()
    {
        return CalcularSubtotal() - CalcularDescuento();
    }

    public void MostrarVenta()
    {
        Console.WriteLine("Producto: " + Producto);
        Console.WriteLine("Precio: " + Precio);
        Console.WriteLine("Cantidad: " + Cantidad);
        Console.WriteLine("Subtotal: " + CalcularSubtotal());
        Console.WriteLine("Descuento: " + CalcularDescuento());
        Console.WriteLine("Total: " + CalcularTotal());
        Console.WriteLine();
    }
}

