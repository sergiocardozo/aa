using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            Orquesta orq = new Orquesta();
            Console.WriteLine("Nombre: {0}, Lugar: {1}" , orq.nombre, orq.lugar, orq.tipo);
            Console.ReadLine();

            Orquesta orq2 = new Orquesta("Sergio", "Adrogue",Orquesta.tipoOrquesta);
            Console.WriteLine("Nombre: {0}, Lugar: {1}, Tipo: {2}", orq.nombre, orq.lugar );
            Console.ReadLine();

            Instrumento inst = new Instrumento();
            Console.WriteLine("Nombre: {0}, Tipo: {1}", inst.nombre, );

            Musico musicoPrincipal = new Musico("Carla", "Perez", 26, inst, orq);
            Console.WriteLine("Nombre: {0}, Apellido: {1}, Edad: {2}, Instrumento: {3}, Orquesta: {4}",
                musicoPrincipal.nombre, musicoPrincipal.apellido, musicoPrincipal.edad,
                musicoPrincipal.instrumento);
            Console.ReadLine();


            Musico m2 = new Musico("Pepe","Grillo",24,inst);

            orq.musicos.Add(musicoPrincipal);
            orq.musicos.Add(m2);

            Orquesta.ImprimirOrquesta(orq);

            Orquesta orquesta2 = new Orquesta("Orquesta2", "Quilmes", Orquesta.tipoOrquesta.Rock);

            Orquesta.ImprimirOrquesta(orquesta2);
        }
    }
}
