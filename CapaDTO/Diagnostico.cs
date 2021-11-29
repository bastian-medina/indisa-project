using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Diagnostico
    {
        private String idDiagnostico;
        private String diagnosticoConsulta;
        private String tipoDiagnostico;

        public string IdDiagnostico { get => idDiagnostico; set => idDiagnostico = value; }
        public string DiagnosticoConsulta { get => diagnosticoConsulta; set => diagnosticoConsulta = value; }
        public string TipoDiagnostico { get => tipoDiagnostico; set => tipoDiagnostico = value; }
    }
}
