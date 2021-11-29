using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Paciente
    {
        private String rutP;
        private String pNombre;
        private String sNombre;
        private String apellidoP;
        private String apellidoM;
        private String sexo;
        private DateTime fechaNacimiento;
        private String nacionalidad;
        private String anos;
        private String prevision;

        public string RutP { get => rutP; set => rutP = value; }
        public string PNombre { get => pNombre; set => pNombre = value; }
        public string SNombre { get => sNombre; set => sNombre = value; }
        public string ApellidoP { get => apellidoP; set => apellidoP = value; }
        public string ApellidoM { get => apellidoM; set => apellidoM = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Anos { get => anos; set => anos = value; }
        public string Prevision { get => prevision; set => prevision = value; }
    }
}
