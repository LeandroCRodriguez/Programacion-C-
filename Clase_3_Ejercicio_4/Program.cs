using LibreriaDeClases3;
namespace Clase_3_Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafo1 = new Boligrafo(15, (ConsoleColor.Blue));
            Boligrafo boligrafo2 = new Boligrafo(50, (ConsoleColor.Red));

            string dibujo;
            //NO ENTIENDO QUE SIGNIFICA DIBUJO ACÁ
            boligrafo1.Pintar(10, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine(boligrafo1.GetTinta());
            Console.WriteLine(boligrafo1.GetColor());
            Console.WriteLine("-------------------------");
            boligrafo1.Recargar();
            Console.WriteLine(dibujo);

        }
    }
}