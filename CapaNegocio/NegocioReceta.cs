using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioReceta
    {

        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            this.con = new Conexion();
            this.con.NombreBaseDeDatos = "Indisa";
            this.con.NombreTabla = "Receta";
            this.con.CadenaConexion = "Data Source=LAPTOP-JVPSLRP5;Initial Catalog=Indisa;Integrated Security=True";
        }


        //guarda una receta
        public void guardarReceta(Receta receta, String idControl)
        {
            this.configurarConexion();

            this.con.CadenaSQL = "INSERT INTO " + this.con.NombreTabla +
                                  " (medicamentos, tratamientos, idControl) VALUES ('"
                                  + receta.Medicamentos + "','"
                                  + receta.Tratamientos + "','"
                                  + idControl + "');";

            this.con.EsSelect = false;
            this.con.conectar();
        }


        //cambia el control de un diagnostico, especificamente su estado ="finalizado"
        public void cambiarEstadoConsulta(String idControl, String rut)
        {
            this.configurarConexion();

            this.con.CadenaSQL = "update control set estado = 'finalizado' where idControl = '" + idControl + "' and rutP = '" + rut + "' and estado = 'en receta'";

            this.con.EsSelect = false;
            this.con.conectar();
        }


    }
}
