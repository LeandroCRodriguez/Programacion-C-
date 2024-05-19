using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases_9
{
    public class Rectangulo : Figura
    {
        double longitud;
        double ancho;

        public Rectangulo(double longitud, double ancho)
        {
            this.longitud = longitud;
            this.ancho = ancho;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (this.longitud + this.ancho);
        }

        public override double CalcularSuperficie()
        {
            return this.longitud * this.ancho;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectángulo...";
        }
    }
}
