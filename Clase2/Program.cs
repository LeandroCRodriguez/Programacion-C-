using LibreriaDeClases1;
namespace Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numeros = new int[10];
            //int numerosIngresados = 0;
            //int numeroMax = 0;
            //int numeroMin = 0;

            //Console.WriteLine("Ingresá 10 números entre el 100 y el -100");

            //while (numerosIngresados < 10)
            //{
            //    string numeroIngresadoString = Console.ReadLine();
            //    int numeroIngresadoInt;
            //    if (int.TryParse(numeroIngresadoString, out numeroIngresadoInt))
            //    {
            //        if (Validador.Validar(numeroIngresadoInt, -100, 100))
            //        {
            //            numeros[numerosIngresados] = numeroIngresadoInt;
            //            numerosIngresados++;
            //            if(numeroIngresadoInt < numeroMin)
            //            {
            //                numeroMin = numeroIngresadoInt;
            //            }
            //            else if(numeroIngresadoInt > numeroMax)
            //            {
            //                numeroMax = numeroIngresadoInt;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Fuera de rango");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("No has ingresado un número");
            //    }
            //}

            //Console.WriteLine("Los números ingresados son:");
            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}
            //Console.WriteLine("Número máximo: {0}", numeroMax);
            //Console.WriteLine("Número mínimo: {0}", numeroMin);

            //###################################################################################################################
            bool bandera = true;
            int numeroIngresadoInt;
            int sumaNumeros = 0;
            char letraIngresadaChar;


            while(bandera)
            {
                Console.WriteLine("Ingresá un número: ");
                string numeroIngresadoStr = Console.ReadLine();

                if (int.TryParse(numeroIngresadoStr, out numeroIngresadoInt))
                {
                    sumaNumeros = sumaNumeros + numeroIngresadoInt;

                }
                else
                {
                    Console.WriteLine("No ingresaste un número");
                }

                Console.WriteLine("¿Querés seguir sumando? S/N");
                string letraIngresadaStr = Console.ReadLine();

                if(char.TryParse(letraIngresadaStr, out letraIngresadaChar))
                {
                    if(Validador.ValidarRespuesta(letraIngresadaChar))
                    {
                        bandera = true;
                    }
                    else
                    {
                        bandera = false;
                    }
                }                
            }
            Console.WriteLine("La suma total fue: {0}",sumaNumeros);
        }
    }
}