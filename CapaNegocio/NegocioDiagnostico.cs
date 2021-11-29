using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioDiagnostico
    {

        private Conexion con;

        public Conexion Con { get => con; set => con = value; }


        public void configurarConexion()
        {
            this.con = new Conexion();
            this.con.NombreBaseDeDatos = "Indisa";
            this.con.NombreTabla = "DiagnosticoFinal";
            this.con.CadenaConexion = "Data Source=LAPTOP-JVPSLRP5;Initial Catalog=Indisa;Integrated Security=True";
        }


        //guarda un diagnostico
        public void guardarDiagnostico(Diagnostico diagnostico, String idControl, String tipoDiagnostico)
        {
            this.configurarConexion();

            this.con.CadenaSQL = "INSERT INTO " + this.con.NombreTabla +
                                  " (diagnostico, idControl, tipoDiagnostico) VALUES ('"
                                  + diagnostico.DiagnosticoConsulta + "','"
                                  + idControl + "','"
                                  + tipoDiagnostico + "');";

            this.con.EsSelect = false;
            this.con.conectar();
        }

        //cambia el control de un diagnostico, especificamente su estado ="en receta"
        public void cambiarEstadoConsulta(String idControl, String rut)
        {
            this.configurarConexion();

            this.con.CadenaSQL = "update control set estado = 'en receta' where idControl = '"+idControl+"' and rutP = '"+rut+"' and estado = 'en espera'";

            this.con.EsSelect = false;
            this.con.conectar();
        }


    }


}
