using LibreriaDeClases2;

namespace Clase_1_Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo,
            //el valor mínimo y el promedio.
            int [] numerosIngresados = new int[5];
            int numMaximo= 0;
            int numMinimo= 0;
            int promedio = 0;
            int suma = 0;
            bool bandera = true;

            Console.WriteLine("Ingresa 5 números: ");

            for(int i = 0;i < numerosIngresados.Length;i++)
            {

                Console.WriteLine("{0} número ingresado: ",i);
                string numeroIngresadoStr = Console.ReadLine();
                if(int.TryParse(numeroIngresadoStr, out int numeroIngresadoInt) && bandera)
                {
                    numerosIngresados[i] = numeroIngresadoInt;
                    numMaximo = numerosIngresados[i];
                    numMinimo = numerosIngresados[i];
                    bandera = false;                    
                }
                else if(numerosIngresados[i] < numMinimo)
                    {
                    numerosIngresados[i] = numeroIngresadoInt;
                    numMinimo = numerosIngresados[i];
                }
                else if (numerosIngresados[i] > numMaximo)
                    {
                    numerosIngresados[i] = numeroIngresadoInt;
                    numMaximo = numerosIngresados[i];
                    }             
            }

            

            foreach(int numero in numerosIngresados)
            {
                suma += numero;
                promedio = suma / 5;
            }

            Console.WriteLine("El número máximo fue: {0}", numMaximo);
            Console.WriteLine("El número mínimo fue: {0}", numMinimo);
            Console.WriteLine("El promedio fue: {0}", promedio);
            
        }
    }
}