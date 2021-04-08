using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClienteAlumno
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ReferenciaServicioAlumnoWCF.AlumnoClient objAlumno = new ReferenciaServicioAlumnoWCF.AlumnoClient();

                objAlumno.nuevoAlumno("1","1", "isidro", 27);
                objAlumno.nuevoAlumno("1","2", "diana", 24);
                objAlumno.nuevoAlumno("1", "1", "juan", 22);
                objAlumno.nuevoAlumno("1", "2", "maria", 23);
                string alumno;
                alumno = objAlumno.getAlumno("1","1");
                Console.WriteLine(alumno);
                alumno = objAlumno.getAlumno("2","1");
                Console.WriteLine(alumno);
                Console.WriteLine("-----------------------------------");
                alumno = objAlumno.getAllAlumnos();
                Console.WriteLine(alumno);
                Console.WriteLine("-----------------------------------");
                if (objAlumno.deleteAlumno("2","2"))
                {
                    Console.WriteLine("alumno borrado correctamente");
                }
                Console.WriteLine("-----------------------------------");
                alumno = objAlumno.getAllAlumnos();
                Console.WriteLine("-----------------------------------");
                if (objAlumno.setAlumno("1","2","dianamod",23))
                {
                    Console.WriteLine("alumno modificado correctamente");
                    alumno = objAlumno.getAlumno("1","2");
                    Console.WriteLine(alumno);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
