using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Instrumento
    {
        public string nombre;
        public tipoInstrumento tipo;

        public enum tipoInstrumento { Acustica, Bajo, Guitarra };
        public Instrumento() { }

        public Instrumento(string nombre, tipoInstrumento );

    }
}
