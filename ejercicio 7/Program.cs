Dictionary<string, Producto> productos = new Dictionary<string, Producto>();

Console.Write("Ingrese la cantidad de productos: ");
int n = int.Parse(Console.ReadLine());

Console.Clear();

for (int i = 0; i < n; i++)
{
    Producto p = new Producto();

    Console.WriteLine("Producto #" + (i + 1));

    Console.Write("Código: ");
    string codigo = Console.ReadLine();

    Console.Write("Nombre: ");
    p.Nombre = Console.ReadLine();

    Console.Write("Precio: ");
    p.Precio = double.Parse(Console.ReadLine());

    Console.Write("Stock: ");
    p.Stock = int.Parse(Console.ReadLine());

    productos.Add(codigo, p);

    Console.Clear();
}

Console.WriteLine("Productos registrados: ");
Console.WriteLine();

foreach (var item in productos)
{
    Console.WriteLine("Código: " + item.Key);
    item.Value.Mostrar();
}

Console.Write("Ingrese código a buscar: ");
string buscar = Console.ReadLine();

if (productos.ContainsKey(buscar))
{
    Console.WriteLine("Producto encontrado:");
    productos[buscar].Mostrar();
}
else
{
    Console.WriteLine("No se encontró el producto.");
}
class Producto
{
    public string Nombre;
    public double Precio;
    public int Stock;

    public string EstadoStock()
    {
        if (Stock == 0)
            return "Agotado";
        else if (Stock <= 5)
            return "Bajo";
        else
            return "Normal";
    }

    public void Mostrar()
    {
        Console.WriteLine($"Nombre: {Nombre} | Precio: {Precio} | Stock: {Stock} | Estado: {EstadoStock()}");
        Console.WriteLine();
    }
}