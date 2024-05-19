using System.Text;

namespace Ejercicios
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Titular: "+this.titular);
            sb.AppendLine("Cantidad: "+this.cantidad);
            return sb.ToString();
        }

        public double Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad += cantidad;
            }
            return this.cantidad;
        }

        public double Retirar(double cantidad)
        {            
            this.cantidad -= cantidad;
            return this.cantidad;            
        }
    }
}