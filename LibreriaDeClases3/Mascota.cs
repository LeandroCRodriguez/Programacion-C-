using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases3
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        List<string> historialDeVacunacion = new List<string>();
        public Mascota(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"La mascota ");
            sb.AppendLine($"- {this.nombre} {this.especie}");
            sb.AppendLine($"Nacida en - {this.fechaNacimiento}");
            sb.AppendLine("tiene las siguientes vacunas: ");
            foreach (string vacuna in historialDeVacunacion)
            {
                sb.Append($" - {vacuna}");
            }
            return sb.ToString();
        }

        public void AgregarVacunas(string vacuna)
        {
            this.historialDeVacunacion.Add(vacuna);
        }

    }
}
