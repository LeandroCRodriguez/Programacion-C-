using LibreriaDeClases_9;

namespace Clase_9_Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SobreSobrescrito objetoSobrescrito = new SobreSobrescrito();
            SobreSobrescrito objetoSobrescrito2 = new SobreSobrescrito();

            Console.WriteLine(objetoSobrescrito.ToString());
            string objeto = "¡Este es mi método ToString sobrescrito!";
            Console.WriteLine("-----------------------------------");

            Console.WriteLine(objetoSobrescrito.Equals(objeto));
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());        
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(objetoSobrescrito.MiPropiedad);
            Console.WriteLine(objetoSobrescrito.MiMetodo());
        }
    }
}