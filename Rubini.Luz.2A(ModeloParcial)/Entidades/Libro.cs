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
        protected int _cantDePaginas;
        protected Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;
        #region Propiedades
        public int CantidaddePaginas { get; }
        #endregion
        #region Constructores
        private Libro()
        {

        }
        public Libro(float precio, string titulo, string nombre, string apellido)
            : this(titulo, new Autor(nombre, apellido), precio)
        {

        }
        public Libro(string titulo, Autor autor, float precio)
        {
            this._autor = autor;
            this._precio = precio;
            this._titulo = titulo;
        }
        #endregion
    }
}
