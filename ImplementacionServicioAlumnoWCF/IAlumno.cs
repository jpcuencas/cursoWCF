using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ImplementacionServicioAlumnoWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAlumno
    {
        [OperationContract]
        bool nuevoAlumno(string instalacion, string dni, string nombre, int edad);

        [OperationContract]
        string getAlumno(string instalacion, string dni);

        [OperationContract]
        string getAllAlumnos();

        [OperationContract]
        bool setAlumno(string instalacion, string dni, string nombre, int edad);

        [OperationContract]
        bool deleteAlumno(string instalacion, string dni);
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio
    [DataContract]
    public class CompositeType
    {
        string nombre;
        string dni;
        string instalacion;
        int edad;

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [DataMember]
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        [DataMember]
        public string Instalacion
        {
            get { return instalacion; }
            set { instalacion = value; }
        }

        [DataMember]
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}
