using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Manual:Libro
    {
        public ETipo tipo;

        public Manual(string titulo, float precio, string nombre, string apellido, ETipo tipo1):base(precio,titulo,nombre,apellido)
        {
            tipo = tipo1;


        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LIBRO:");
            sb.AppendLine(base.ToString());
            sb.AppendLine("TIPO:" + this.tipo);

            sb.AppendLine("---------------------");

            return sb.ToString();
        }


        public static bool operator ==(Manual a, Manual b)
        {
            bool retorno = false;
            if (a.tipo == b.tipo && a._autor == b._autor && a._cantidadDePaginas == b._cantidadDePaginas && a._precio == b._precio && a._titulo == b._titulo)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }


        public static implicit operator Double(Manual m)
        {

            return m._precio;
        }





    }
}
