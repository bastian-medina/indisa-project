using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Receta
    {
        private String idReceta;
        private String medicamentos;
        private String tratamientos;

        public string IdReceta { get => idReceta; set => idReceta = value; }
        public string Medicamentos { get => medicamentos; set => medicamentos = value; }
        public string Tratamientos { get => tratamientos; set => tratamientos = value; }
    }
}
