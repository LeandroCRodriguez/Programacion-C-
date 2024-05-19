using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaDeClases_9
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();
        

        public override string ToString()
        {
            return "Este es mi método sobrescrito";
        }
        public override bool Equals(object? obj)
        {
            if (obj != null && obj.GetType() == this.GetType())
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }

    }
}
