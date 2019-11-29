using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Persona
    {
        private int edad;
        public string nombre;
        public string apellido;
        //constructor sin parametros
        public Persona(){ }
        //constructor con parametros
        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
        //seteamos los datos del objeto
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
        //obtenemos la posicion del objeto
        public int getEdad()
        {
            return this.edad;
        }

        public void cumplirAnios()
        {
            this.edad++;
        }
    }
}
