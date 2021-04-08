using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImplementacionServicioAlumnoWCF
{
    public class AlumnoDTO
    {
        string nombre;
        string instalacion;
        string dni;
        int edad;
        

        public AlumnoDTO()
        {
            instalacion = "-1";
            nombre = "";
            dni = "-1";
            edad = -1;
        }

        public AlumnoDTO(string pe_dni, string pe_nombre, int pe_edad,string pe_instalacion)
        {
            instalacion = pe_instalacion;
            nombre = pe_nombre;
            dni = pe_dni;
            edad = pe_edad;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Instalacion
        {
            get { return instalacion; }
            set { instalacion = value; }
        }
    }
}
