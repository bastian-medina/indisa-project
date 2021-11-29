using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Medico
    {
        static private String rutM;
        private String auxRutM;
        private String contrasena;
        static private String nombres;
        static private String apellidos;
        static private String especialidad;
        private int salario;
        private String telefono;
        private String direccion;

        public static string RutM { get => rutM; set => rutM = value; }
        public string AuxRutM { get => auxRutM; set => auxRutM = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public static string Nombres { get => nombres; set => nombres = value; }
        public static string Apellidos { get => apellidos; set => apellidos = value; }
        public static string Especialidad { get => especialidad; set => especialidad = value; }
        public int Salario { get => salario; set => salario = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
