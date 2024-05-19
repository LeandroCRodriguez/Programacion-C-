using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar ()
        {
            cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(Euro.GetCotizacion() * d.cantidad);  //No entiendo
        }

        public static explicit operator Peso(Dolar d)

        {
            return new Peso(Peso.GetCotizacion() * d.cantidad);
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);  //No entiendo
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d.cantidad == (Dolar)e;    //No entiendo        
        }      
        public static bool operator ==(Dolar d, Peso p)
        {
            return d.cantidad == p.GetCantidad();  //No entiendo            
        }
        
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).cantidad);
        }


        public static Dolar operator -(Dolar d, Peso p)
        {
            //return new Dolar(d.cantidad - p.GetCantidad());
            return new Dolar(d.cantidad - ((Dolar)p).cantidad); 
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            //return new Dolar(d.cantidad + e.GetCantidad());   es sumar peras con manzanas
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad + p.GetCantidad());
        }
    }
}
