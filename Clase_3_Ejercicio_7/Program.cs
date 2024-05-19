using LibreriaDeClases3;

namespace Clase_3_Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaDeNacimientoMascota1 = new DateTime(2020, 4, 15);
            DateTime fechaDeNacimientoMascota2 = new DateTime(2014, 6, 10);
            DateTime fechaDeNacimientoMascota3 = new DateTime(1999, 1, 5);
            DateTime fechaDeNacimientoMascota4 = new DateTime(1998, 2, 6);

            Cliente cliente1 = new Cliente("Matias", "Perez", 1532456094);
            Mascota mascota1 = new Mascota("Salchicha", "Nube", fechaDeNacimientoMascota1);

            Cliente cliente2 = new Cliente("Lucía", "Fernandez", 1543658709);
            Mascota mascota2 = new Mascota("callejera", "Churita", fechaDeNacimientoMascota2);

            Cliente cliente3 = new Cliente("Carlos", "Lopez", 1564987533);
            Mascota mascota3 = new Mascota("callejero", "Augusto", fechaDeNacimientoMascota3);
            Mascota mascota4 = new Mascota("Schnauzer", "Pilo", fechaDeNacimientoMascota4);

            Console.WriteLine(cliente1.MostrarDatos());
            Console.WriteLine(mascota1.MostrarDatos());


            mascota2.AgregarVacunas("Triple Felina");
            Console.WriteLine(cliente2.MostrarDatos());
            Console.WriteLine(mascota2.MostrarDatos());

            mascota4.AgregarVacunas("Rabia");
            Console.WriteLine(cliente3.MostrarDatos());
            Console.WriteLine(mascota3.MostrarDatos());
            Console.WriteLine(mascota4.MostrarDatos());

            
        }
    }
}