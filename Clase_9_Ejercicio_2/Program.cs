using LibreriaDeClases_9;

namespace Clase_9_Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado(2);
            Circulo circulo = new Circulo(6);
            Rectangulo rectangulo = new Rectangulo(2,4);

            List<Figura> figuras = new List<Figura>();
            figuras.Add(cuadrado);
            figuras.Add(circulo);
            figuras.Add(rectangulo);

            foreach (Figura figura in figuras)
            {
            Console.WriteLine(figura.Dibujar());
            Console.WriteLine(figura.CalcularSuperficie());
            Console.WriteLine(figura.CalcularPerimetro());
            Console.WriteLine(figura.GetType());
            }      
        }
    }
}

//Terminado