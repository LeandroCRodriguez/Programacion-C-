using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaDeClases3
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private int teléfono;

        public Cliente(string nombre, string apellido, int teléfono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.teléfono = teléfono;
        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetApellido()
        {
            return this.apellido;
        }
        public int GetTelefono()
        {
            return this.teléfono;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El cliente ");
            sb.AppendLine($"- {this.nombre} {this.apellido}");
            sb.AppendLine($"- {this.teléfono}");
            return sb.ToString();
        }


    }
}
