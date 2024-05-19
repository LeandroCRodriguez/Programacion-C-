namespace LibreriaDeClases_9
{
    public class SobreSobrescrito : Sobrescrito
    {
        public override string MiPropiedad => miAtributo.ToString();

               
        

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}