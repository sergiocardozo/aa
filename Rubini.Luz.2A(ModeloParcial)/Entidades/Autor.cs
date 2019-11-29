using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        private string _apellido;
        private string _nombre;

        public Autor(string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }
        public static bool operator ==(Autor autorA, Autor autorB)
        {
            bool retorno = false;
            if (autorA._nombre == autorB._nombre && autorA._apellido == autorB._apellido)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Autor autorA, Autor autorB)
        {
            return !(autorA == autorB);
        }
    }
}
