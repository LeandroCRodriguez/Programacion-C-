using System.Runtime.CompilerServices;

namespace LibreriaDeClases_4
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador():this(0)
        {

        }

        public long Sumar(long a, long b)
        {
            long suma = a + b;
            this.cantidadSumas += 1;
            return suma;
        }

        public string Sumar(string a, string b)
        {
            string concatenacion = a + b;
            this.cantidadSumas++;
            return concatenacion;
        }

        public static explicit operator int(Sumador s) 
        { 
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return (int)s1 + (int)s2; //Por que le agrega el (int)? si ademas devuelve un long
        }

        public static bool operator | (Sumador s1, Sumador s2)
        {
            if(s1.cantidadSumas ==  s2.cantidadSumas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

    }
}