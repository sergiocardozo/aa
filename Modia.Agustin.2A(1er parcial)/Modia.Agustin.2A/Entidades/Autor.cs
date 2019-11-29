using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Autor
    {
        string apellido;
        string nombre;

        public Autor( string nombre1, string apellido2)
        {
            nombre = nombre1;
            apellido = apellido2;
        }

        public static implicit operator string(Autor A)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("NOMBRE: \r\n");
            sb.AppendLine(A.nombre);
            sb.AppendLine("\r\n");
            sb.AppendLine("APELLIDO :");
            sb.AppendLine(A.apellido);
            sb.AppendLine("\r\n");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }


        public static bool operator ==(Autor a , Autor b)
        {
            bool retorno = false;
            if (a.nombre == b.nombre && a.apellido == b.apellido)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }






    }
}
