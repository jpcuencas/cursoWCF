using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImplementacionServicioAlumnoWCF
{
    public class Alumnos
    {
        static Alumnos instance = null;

        List<AlumnoDTO> alumnos;

        Alumnos()
        {
            alumnos = new List<AlumnoDTO>();
        }

        public static Alumnos Instance
        {
            get
            {
                if ( instance == null)
                {
                    instance = new Alumnos();
                }
                return instance;
            }            
        }

        public bool nuevoAlumno(string instalacion,string dni, string nombre, int edad)
        {
            if (buscarAlumno(instalacion,dni) != -1)
            {
                return false;
            }

            AlumnoDTO al = new AlumnoDTO(dni, nombre, edad,instalacion);
            alumnos.Add(al);
            return true;
        }

        public string getAlumno(string instalacion,string dni)
        {
            int alumno = buscarAlumno(dni,instalacion);
            if (alumno == -1)
            {
                return "";
            }

            return alumnoString(alumnos[alumno]);
        }

        public string getAllAlumnos()
        {
            if (alumnos.Count == 0)
            {
                return "";
            }

            string retorno = "<alumnos>";
            foreach (AlumnoDTO alu in alumnos)
            {
                retorno += alumnoString(alu);
            }
            retorno += "</alumnos>";
            return retorno;
        }

        public bool setAlumno(string instalacion,string dni, string nombre, int edad)
        {
            int alumno = buscarAlumno(instalacion,dni);
            if (alumno == -1)
            {
                return false;
            }

            alumnos[alumno].Nombre = nombre;
            alumnos[alumno].Edad = edad;
            return true;
        }

        public bool deleteAlumno(string instalacion,string dni)
        {
            int alumno = buscarAlumno(instalacion,dni);
            if (alumno == -1)
            {
                return false;
            }
            alumnos.Remove(alumnos[alumno]);
            return true;
        }

        #region Funciones auxiliares

        //devuelve la posicion del alumno en el vector
        public int buscarAlumno(string pe_instalacion,string pe_dni)
        {
            int encontrado = -1;
            for (int i = 0; i < alumnos.Count && encontrado == -1; i++)
            {
                if (alumnos[i].Dni == pe_dni && alumnos[i].Instalacion == pe_instalacion)
                {
                    encontrado = i;
                }
            }

            return encontrado;
        }
        //devuelve formateado el alumno
        public string alumnoString(AlumnoDTO pe_alumno)
        {
            string retorno = "<alumno>";
            retorno += "<nombre>" + pe_alumno.Nombre + "</nombre>";
            retorno += "<dni>" + pe_alumno.Dni + "</dni>";
            retorno += "<edad>" + pe_alumno.Edad.ToString() + "</edad>";
            retorno += "</alumno>";
            return retorno;
        }
        #endregion
    }
}
