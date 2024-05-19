using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        private Peso()
        {
            cotizRespectoDolar = 1 / 102.65;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.cantidad / Peso.GetCotizacion());
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);  //Castea de Euro a Dolar y de Dolar a Peso. Lo hace porque ya está hecho en otras partes del código.
            //Además de que no puedo castear de Euro a Peso porque tengo el atributo cotizRespectoDolar
        }

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        public static bool operator == (Peso p, Dolar d)
        {
            return p == (Peso)d;  //Sigo sin entender esta línea
            //return p.cantidad == ((Peso)d).cantidad;   Yo la haría así en todo caso porque comparo cantidades, no TODO el objeto.
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator == (Peso p, Euro e)
        {
            return p == (Peso)e;
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Peso p1, Peso p2 )
        {
            return p1.cantidad == p2.cantidad;
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        public static Peso operator +(Peso p,Dolar d)
        {
            return new Peso(p.cantidad + ((Peso)d).cantidad);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.cantidad - ((Peso)d).cantidad);
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.cantidad + ((Peso)e).cantidad);
        }
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.cantidad -((Peso)e).cantidad);
        }
    }
}
