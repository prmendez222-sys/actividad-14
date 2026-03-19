List<Pedido> pedidos = new List<Pedido>();

Console.Write("Ingrese la cantidad de pedidos: ");
int n = int.Parse(Console.ReadLine());

Console.Clear();

for (int i = 0; i < n; i++)
{
    Pedido p = new Pedido();

    Console.WriteLine("Pedido #" + (i + 1));

    Console.Write("Cliente: ");
    p.Cliente = Console.ReadLine();

    Console.Write("Producto: ");
    p.Producto = Console.ReadLine();

    Console.Write("Cantidad: ");
    p.Cantidad = int.Parse(Console.ReadLine());

    Console.Write("Precio unitario: ");
    p.PrecioUnitario = double.Parse(Console.ReadLine());

    pedidos.Add(p);

    Console.Clear();
}

double totalGeneral = 0;

Console.WriteLine("Pedidos registrados: ");

foreach (Pedido p in pedidos)
{
    p.Mostrar();
    totalGeneral += p.Total();
}

Console.WriteLine("TOTAL GENERAL DE PEDIDOS: " + totalGeneral);
class Pedido
{
    public string Cliente;
    public string Producto;
    public int Cantidad;
    public double PrecioUnitario;

    public double Subtotal()
    {
        return Cantidad * PrecioUnitario;
    }

    public double CostoEnvio()
    {

        if (Subtotal() >= 100)
            return 0; 
        else if (Subtotal() >= 50)
            return 5;
        else
            return 10;
    }

    public double Total()
    {
        return Subtotal() + CostoEnvio();
    }

    public void Mostrar()
    {
        Console.WriteLine($"Cliente: {Cliente} | Producto: {Producto} | Cantidad: {Cantidad} | Precio: {PrecioUnitario} | Subtotal: {Subtotal()} | Envío: {CostoEnvio()} | Total: {Total()}");
        Console.WriteLine();
    }
}