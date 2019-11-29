using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Libro
    {
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected static Random _generadorDePaginas;

        public int cantidadDePaginas
        {

            get
            {
                if (_cantidadDePaginas == 0)
                {
                    _cantidadDePaginas = _generadorDePaginas.Next(10, 580);
                }
                    return _cantidadDePaginas;
                
            }

        }
        protected float _precio;
        protected string _titulo;



       static Libro()
        {
             _generadorDePaginas.Next(10, 580);


        }

        public Libro(float precio, string titulo, string nombre, string apellido)
        {
            _autor = new Autor(nombre, apellido);
            _precio = precio;
            _titulo = titulo;

        }

         public Libro(string titulo, Autor autor, float precio):this (precio,titulo, "nombre ", "apellido")
        {
           


        }


        public static explicit operator string(Libro l)
        {
            
            return Mostrar(l);
        }



        static private string Mostrar( Libro l)
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AUTOR: \r\n");
            sb.AppendLine(l._autor.ToString());
            sb.AppendLine("\r\n");
            sb.AppendLine("cant paginas :");
            sb.AppendLine(l._cantidadDePaginas.ToString());
            sb.AppendLine("\r\n");
            sb.AppendLine("PRECIO: \r\n");
            sb.AppendLine(l._precio.ToString());
            sb.AppendLine("\r\n");
            sb.AppendLine("TITULO :");
            sb.AppendLine(l._titulo);
            sb.AppendLine("\r\n");

            sb.AppendLine("---------------------");

            return sb.ToString();
        }


        public static bool operator ==(Libro a, Libro b)
        {
            bool retorno = false;
            if (a._titulo == b._titulo && a._autor == b._autor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }







    }
}
