using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LibreriaDeClases8
{
    public class Camion : VehiculoTerrestre
    {
        //cantidadRuedas: short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, pesoCarga : int.
        
        private int pesoCarga;
        private short cantidadMarchas;


        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga)
            :base(cantidadRuedas,cantidadPuertas,color)
        {            
            this.pesoCarga = pesoCarga;
            this.cantidadMarchas = cantidadMarchas;

    }
}
}
