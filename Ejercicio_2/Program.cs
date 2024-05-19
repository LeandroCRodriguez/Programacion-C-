using Ejercicios;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaNacimiento1 = new DateTime(1987, 2, 25);
            DateTime fechaNacimiento2 = new DateTime(2020, 6, 15);
            DateTime fechaNacimiento3 = new DateTime(1777, 12, 31);

            Persona persona1 = new Persona("Lele", fechaNacimiento1,33257736);
            Persona persona2 = new Persona("Pablo", fechaNacimiento2,12456789);
            Persona persona3 = new Persona("Vero", fechaNacimiento3,23321654);

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona3.Mostrar());
        }
    }
}