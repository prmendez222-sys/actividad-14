void Presionar()
{
    Console.WriteLine();
    Console.WriteLine("Presione Enter Para continuar");
    Console.ReadLine();
}

List<Producto> productos = new List<Producto>();

string opcion;
do
{
    Console.WriteLine("1. ingresar productos");
    Console.WriteLine("2. mostrar productos registrado");
    Console.WriteLine("3. valor total del inventario y producto con el mayor precio");
    Console.WriteLine("4. salir");
    Console.WriteLine();
    Console.Write("ingrese una opcion: ");
    opcion = Console.ReadLine();
    Console.Clear();

    switch (opcion)
    {
        case "1":
            Console.Write("Cuantos Productos desea ingresar: ");
            int n = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 0; i < n; i++)
            {
                Producto p = new Producto();
                Console.WriteLine($"ingrese datos del Producto {i + 1}: ");
                Console.WriteLine();
                Console.Write("Nombre: "); p.nombre = Console.ReadLine();
                Console.Write("Precio en (Q.): ");  p.precio = double.Parse(Console.ReadLine());
                Console.Write("cantida en stock: ");  p.cantidad = int.Parse(Console.ReadLine());               
                productos.Add(p);
                Console.Clear();
            }

            Console.WriteLine("Productos Guardados con exito");
            Presionar();
            break;
        case "2":
            if (productos.Count == 0)
            {
                Console.WriteLine("no hay productos registrados");
            }
            else
            {
                foreach (Producto p in productos)
               {
                    p.MostrarInfo();
                }
            }
            Presionar();
            break;
    }
} while (opcion != "4");

class Producto
{
    public string nombre;
    public double precio;
    public int cantidad;

    public double ValorTproducto()
    {
        return (precio * cantidad);
    }

    public string ObtenerEstado()
    {
        if (cantidad > 0) return "stock bajo";
        else if (cantidad >= 5) return "stock suficiente";
        else return "sin stock";
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"nombre: {nombre}  |  Precio unitario: Q.{precio}  |  " +
            $"cantidad en stock: {cantidad}  |  valor Total del stock: Q.{ValorTproducto()}");
    }
}