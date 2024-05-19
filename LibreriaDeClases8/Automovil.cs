namespace LibreriaDeClases8
{
    public enum Colores { Rojo, Blanco, Azul, Gris, Negro };

    public class Automovil : VehiculoTerrestre
    {
        //cantidadRuedas : short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, cantidadPasajeros : int
        
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) 
            : base(cantidadRuedas, cantidadPuertas, color)
        {            
            this.cantidadPasajeros = cantidadPasajeros;
            this.cantidadMarchas = cantidadMarchas;
        }
    }
}