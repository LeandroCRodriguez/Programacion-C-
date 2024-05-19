using Billetes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = 1 / 1.17;
        }
        
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }


        public Euro(double cantidad, double cotizacion) :this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }


        public static  double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        //Codigo del chat
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / cotizRespectoDolar);
        }       

        public static explicit operator Peso(Euro e)
        {
            //return new Peso(e.cantidad / cotizRespectoDolar);
            return (Peso)((Dolar)e);  //Castea de Euro a Dolar y de Dolar a Peso. Lo hace porque ya está hecho en otras partes del código.
            //Además de que no puedo castear de Euro a Peso porque tengo el atributo cotizRespectoDolar
        }


        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;  //No entiendo porque en la clase Dolar me deja comparar e.cantidad == (Euro)d y acá no. acá estoy comparando todo,
                                    //No solo cantidades
            //return e.cantidad == d.GetCantidad();    Yo haría esto
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return e == (Euro)p;
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static bool operator == (Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }

        public static bool operator != (Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).cantidad);
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro (e.cantidad + ((Euro)p).cantidad);
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.cantidad - ((Euro)p).cantidad);
        }
    }
}





