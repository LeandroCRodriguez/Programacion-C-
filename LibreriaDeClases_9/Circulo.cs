using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases_9
{
    public sealed class Circulo : Figura
    {
        double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double CalcularPerimetro()
        {
            double resultado = 2 * Math.PI * this.radio;
            return Math.Round(resultado,2);

        }

        public override double CalcularSuperficie()
        {

            double resultado = Math.PI * Math.Pow(this.radio, 2);
            return Math.Round(resultado,2);
        }

        public override string Dibujar()
        {
            return "Dibujando círculo...";
        }
    }
}
