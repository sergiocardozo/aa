using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Novela : Libro
    {
        public EGenero genero;

        public Novela(string titulo, float precio, Autor autor, EGenero genero1) : base(titulo,autor,precio)
        {

            genero = genero1;

        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LIBRO:");
            sb.AppendLine(base.ToString());
            sb.AppendLine("GENERO:" + this.genero);

            sb.AppendLine("---------------------");

            return sb.ToString();
        }


        public static bool operator ==(Novela a, Novela b)
        {
            bool retorno = false;
            if (a.genero == b.genero && a._autor == b._autor && a._cantidadDePaginas == b._cantidadDePaginas && a._precio == b._precio && a._titulo == b._titulo)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }


        public static implicit operator Double(Novela n)
        {

            return n._precio;
        }








    }
}
