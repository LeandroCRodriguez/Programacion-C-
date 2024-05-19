using Ejercicios;

namespace Clase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Adolfo", 100);

            cuenta1.Ingresar(100);
            Console.WriteLine(cuenta1.Mostrar());
            cuenta1.Retirar(300);
            Console.WriteLine(cuenta1.Mostrar());
            cuenta1.Ingresar(-100);
            Console.WriteLine(cuenta1.Mostrar());
        }
    }
}