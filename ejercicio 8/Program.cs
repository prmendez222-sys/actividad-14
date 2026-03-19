List<Cuenta> cuentas = new List<Cuenta>();

Console.Write("Ingrese la cantidad de cuentas: ");
int n = int.Parse(Console.ReadLine());

Console.Clear();

for (int i = 0; i < n; i++)
{
    Cuenta c = new Cuenta();

    Console.WriteLine("Cuenta #" + (i + 1));

    Console.Write("Titular: ");
    c.Titular = Console.ReadLine();

    Console.Write("Saldo inicial: ");
    c.Saldo = double.Parse(Console.ReadLine());

    cuentas.Add(c);

    Console.Clear();
}

foreach (Cuenta c in cuentas)
{
    Console.WriteLine($"Cuenta de {c.Titular}");

    Console.Write("Monto a depositar: ");
    double deposito = double.Parse(Console.ReadLine());
    c.Depositar(deposito);

    Console.Write("Monto a retirar: ");
    double retiro = double.Parse(Console.ReadLine());
    c.Retirar(retiro);

    Console.Clear();
}

Console.WriteLine("Saldos finales");

foreach (Cuenta c in cuentas)
{
    c.Mostrar();
}
class Cuenta
{
    public string Titular;
    public double Saldo;

    public void Depositar(double monto)
    {
        Saldo += monto;
    }

    public void Retirar(double monto)
    {
        if (monto <= Saldo)
        {
            Saldo -= monto;
        }
        else
        {
            Console.WriteLine("Fondos insuficientes");
        }
    }

    public void Mostrar()
    {
        Console.WriteLine($"Titular: {Titular} | Saldo: {Saldo}");
        Console.WriteLine();
    }
}