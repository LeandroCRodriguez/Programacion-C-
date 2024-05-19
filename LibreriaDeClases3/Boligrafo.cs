using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases3
{
    
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private short tinta;
        private ConsoleColor color;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        private void SetTinta(short tinta) 
        {
            int nuevaCantidadTinta = this.tinta + tinta;
            if(nuevaCantidadTinta >= 0 && nuevaCantidadTinta <= cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)             //NO ENTIENDO QUE SIGNIFICA DIBUJO ACÁ
        {
            dibujo = "";
            short tintaGastada = (short)(this.tinta - gasto);

            for (int i = 0; i < tintaGastada; i++)
            {
                dibujo += "*";
            }

            return tintaGastada > 0;
        }
    }
}
