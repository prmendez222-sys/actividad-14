List<Empleado> empleados = new List<Empleado>();

Console.Write("Cuantos empleados decea ingresar: ");
int n = int.Parse(Console.ReadLine());

Console.Clear();

for (int i=0; i<n; i++)
{
    Empleado e = new Empleado();
    Console.WriteLine($"ingrese datos del Empleado {i+1}: ");
    Console.WriteLine();
    Console.Write("Nombre: "); e.nombre = Console.ReadLine();
    Console.Write("Puesto: "); e.puesto = Console.ReadLine();
    Console.Write("Salario Mensual: "); e.salarioMensual = double.Parse(Console.ReadLine());
    empleados.Add(e);
    Console.Clear();
}

foreach(Empleado e in empleados)
{
    e.MostrarInfo();
}
class Empleado
{
    public string nombre;
    public string puesto;
    public double salarioMensual;

    public double SalarioAnual()
    {
        return (salarioMensual * 12);
    }

    public double Bono()
    {
        if (salarioMensual < 5000) return (salarioMensual * 0.08);
        else if (salarioMensual >= 5000 && salarioMensual <= 9000) return (salarioMensual * 0.10);
        else return (salarioMensual * 0.20);
    }

    public string EstadoSalario()
    {
        if (salarioMensual >= 10000) return "Salario Alto";
        else if (salarioMensual >= 5000 && salarioMensual <= 9999) return "Salario medio";
        else return "Salario basico";
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {nombre}  |  Puesto: {puesto}  |  " + 
            $"  Salario Mensual: Q.{salarioMensual:F2}  |  Salario anual: Q.{SalarioAnual():F2}" +
            $"  |  Bono: Q.{Bono():F2}  |  Clasificacion: Q.{EstadoSalario()}");
        Console.WriteLine();
    }
}