using System;
using CapaDTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Control
    {
        private String idControl;
        private String causa;
        private String prioridad;
        private String frecuenciaCardiaca;
        private String frecuenciaRespiratoria;
        private String presionArterial;
        private String saturacionO2;
        private String temperatura;
        private String dolor;
        private DateTime fecha;
        private String estado;
        private Paciente auxPaciente;




        public string IdControl { get => idControl; set => idControl = value; }
        public string Causa { get => causa; set => causa = value; }
        public string Prioridad { get => prioridad; set => prioridad = value; }
        public string FrecuenciaCardiaca { get => frecuenciaCardiaca; set => frecuenciaCardiaca = value; }
        public string FrecuenciaRespiratoria { get => frecuenciaRespiratoria; set => frecuenciaRespiratoria = value; }
        public string PresionArterial { get => presionArterial; set => presionArterial = value; }
        public string SaturacionO2 { get => saturacionO2; set => saturacionO2 = value; }
        public string Temperatura { get => temperatura; set => temperatura = value; }
        public string Dolor { get => dolor; set => dolor = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Estado { get => estado; set => estado = value; }
        public Paciente AuxPaciente { get => auxPaciente; set => auxPaciente = value; }
    }
}
