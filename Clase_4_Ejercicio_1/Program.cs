using LibreriaDeClases_4;

namespace Clase_4_Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador(2);
            Sumador sumador2 = new Sumador(5);

            ;
            Console.WriteLine(sumador1.Sumar("Lele", "Rina"));
            Console.WriteLine(sumador1.Sumar(2,2));

            long sumadorSuma = sumador1 + sumador2;
            Console.WriteLine("Cantidad de suma {0}", sumadorSuma);

            bool cantidades = sumador1 | sumador2;
            Console.WriteLine("¿Tienen cantidades iguales?", cantidades);
        }
    }
}