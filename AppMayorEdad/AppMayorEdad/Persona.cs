using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMayorEdad
{
    class Persona
    {
        //Atributos
        string nombre;
        int edad;

        //Metodo constructor vacio
        public Persona()
        {
        }

        //Metodo Constructor
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;

        }

        //Metodo get y set

        public string Nombre
        {
            get { return nombre;}
            set { nombre = value; }
                       
        }

         public int Edad
        {
            get { return edad;}
            set { edad = value; }
                       
        }


    }
}
