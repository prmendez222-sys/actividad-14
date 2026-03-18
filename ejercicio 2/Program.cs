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
        case "3":
            if (productos.Count == 0)
            {
                Console.WriteLine("no hay estudiantes registrado");
            }
            else
            {
                Console.WriteLine("El Producto con el precio mas costoso es: ");
                Console.WriteLine();
                double valorT = 0;

                Producto mayor = productos[0];

                foreach (Producto p in productos)
                {
                    valorT += p.ValorTproducto();
                    if (p.precio > mayor.precio)
                    {
                        mayor = p;
                    }
                }
                mayor.MostrarInfo();

                Console.WriteLine();
                Console.WriteLine($"valor total del inventario general: Q.{valorT}");

            }
            Presionar();
            break;
        case "4":
            break;
        default:
            Console.WriteLine("opcion no valida");
            Presionar();
            break;
    }
    Console.Clear();
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
        if (cantidad > 0 && cantidad<=5) return "stock bajo";
        else if (cantidad >= 6) return "stock suficiente";
        else return "sin stock";
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"nombre: {nombre}  |  Precio unitario: Q.{precio}  |  " +
            $"estado del stock: {ObtenerEstado()}  |  valor Total del stock: Q.{ValorTproducto()}");
        Console.WriteLine();
    }
    j
}