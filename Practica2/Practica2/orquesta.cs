using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Orquesta
    {
        public string nombre;
        public string lugar;
        public tipoOrquesta tipo;
        public List<Musico> musicos;

        public enum tipoOrquesta {Sinfonica, Rock, Heavy}
        public Orquesta() { }

        public Orquesta(string nombre, string lugar, tipoOrquesta orquesta)
        {
            this.nombre = nombre;
            this.lugar = lugar;
            this.tipo = orquesta;
            this.musicos = new List<Musico>();
        }

        public string getOrquestaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre Orquesta: {0}, Lugar: {1}, Tipo: {2}", this.nombre, this.lugar, this.tipo);

            return sb.ToString();

        }

        public static void ImprimirOrquesta(Orquesta orquesta)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(orquesta.getOrquestaToString());
            if(orquesta.musicos.Count > 0)
            {
                sb.AppendFormat("Lista de Musicos \n");
                foreach (Musico element in orquesta.musicos)//element 1 musico in dentro de la lista
                {
                    sb.AppendFormat("Musico: {0}\n", element.nombre);
                    sb.AppendFormat("Instrumento: {0}\n", element.instrumento.nombre);

                }
            }
            else
            {
                sb.AppendFormat("NO HAY MUSICOS");
            }
            Console.WriteLine("{0}", sb.ToString());
            Console.ReadLine();
        }


    }

    
}
