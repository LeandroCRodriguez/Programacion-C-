using LibreriaDeClases8;

namespace Clase_8_Ejercicio_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Camion camion1 = new Camion(10,6, Colores.Negro,18,4500);
            Automovil auto1 = new Automovil(4, 4, Colores.Rojo, 5, 5);
            Moto moto1 = new Moto(2, 0, Colores.Gris, 250);

            Console.WriteLine(camion1);
            Console.WriteLine(auto1);
            Console.WriteLine(moto1);
            //Me falta mostrar los datos por pantalla
            
        }
    }
}