using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ImplementacionServicioAlumnoWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Alumno : IAlumno
    {
        public bool nuevoAlumno(string instalacion, string dni, string nombre, int edad)
        {
            return Alumnos.Instance.nuevoAlumno(instalacion,dni, nombre, edad);
        }

        public string getAlumno(string instalacion, string dni)
        {
            return Alumnos.Instance.getAlumno(instalacion,dni);
        }

        public string getAllAlumnos()
        {
            return Alumnos.Instance.getAllAlumnos();
        }

        public bool setAlumno(string instalacion,string dni, string nombre, int edad)
        {
            return Alumnos.Instance.setAlumno(instalacion, dni, nombre, edad);
        }

        public bool deleteAlumno(string instalacion,string dni)
        {
            return Alumnos.Instance.deleteAlumno(instalacion,dni);
        }
    }
}
