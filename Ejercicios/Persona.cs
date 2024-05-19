using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Persona
    {
        private string nombre;
        DateTime fechaNacimiento = new DateTime();
        private int dni;

        public Persona(string nombre, DateTime fechaNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public DateTime GetFechaNacimiento()
        {
            return fechaNacimiento;
        }
        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento= fechaNacimiento;
        }

        public int GetDni()
        {
            return this.dni;
        }

        public void SetDni(int dni)
        {
            this.dni= dni;
        }

        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - this.fechaNacimiento.Year;
            return edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {this.nombre}");
            sb.Append($" Dni: {this.dni}");
            sb.Append($" Edad: {CalcularEdad()}");
            sb.Append($" Fecha de nacimiento: {this.fechaNacimiento}");

            return sb.ToString();
        }

        public string EsMayorEdad()
        {
            string respuesta;

            if(CalcularEdad()>18)
            {
                respuesta = "Es mayor";
            }
            else
            {
                respuesta = "Es menor";
            }
            return respuesta;
        }

    }
}
