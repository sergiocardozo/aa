using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Bibloteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        Bibloteca()
        {
            _libros = new List<Libro>();

        }
        Bibloteca(int capacidad)
        {
            _capacidad = capacidad;

        }


        public double PrecioDeManual { get
            {

                return 5;

            } }
        public double PrecioDeNovelas
        {
            get
            {

                return 10;

            }
        }
        public double PrecioTotal
        {
            get
            {

                return PrecioDeManual + PrecioDeNovelas;

            }
        }

        static public string Mostrar (Bibloteca e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Libro libro1 in e._libros)
            {
                sb.AppendLine(libro1.ToString());
            }

            sb.AppendLine("CAPACIDAD:" +e._capacidad);
            return sb.ToString();

        }

        public static implicit operator Bibloteca(int Capacidad)
        {
            Bibloteca biblo = new Bibloteca();
            biblo._capacidad = Capacidad;

            return biblo;
        }

        public static bool operator ==(Bibloteca e, Libro l)
        {
            bool retorno = false;

            foreach (Libro libro1 in e._libros)
            {
               if (l == libro1)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Bibloteca e, Libro l)
        {
            return !(e == l);
        }

        public static Bibloteca operator +(Bibloteca e, Libro l)
        {
                    if (e._capacidad > 0 && e != l)
                    {
                        e._libros.Add(l);
                    }
                
                return e;
        }

       

        double ObtenerPrecio(ELibro tipoLibro)
        {
            double retorno = 0;
            int contmanual = 0;
            int contnovela = 0;
            
            foreach (Libro item in this._libros)
            {
                if (item is Manual)
                {
                    contmanual++;
                }
                else if (item is Novela)
                {
                    contnovela++;
                }
               
            }
            switch (tipoLibro)
            {
             
                case ELibro.Manual:
                    {
                        retorno = contmanual * PrecioDeManual ;
                    }
                    break;
                case ELibro.Novela:
                    {
                        retorno = contnovela *PrecioDeNovelas ;
                    }
                    break;
                case ELibro.Ambos:
                    {
                        retorno = (contmanual + contnovela) * PrecioTotal;
                    }
                    break;
                default:
                    break;
            }

            return retorno;
        }



    }
}
