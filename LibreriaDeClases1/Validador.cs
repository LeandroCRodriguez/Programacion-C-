namespace LibreriaDeClases1
{
    public class Validador
    {   
        public static bool Validar(int valor, int min, int max)
        {
            if (valor > min && valor < max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidarRespuesta(char letra)
        {
            if (letra == 'S' || letra == 's')
            {
                return true;
            }
            return false;
        }
    }
}