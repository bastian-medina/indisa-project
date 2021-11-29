using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioMedico
    {

        private Conexion con;

        public Conexion Con { get => con; set => con = value; }



        public void configurarConexion()
        {
            this.con = new Conexion();
            this.con.NombreBaseDeDatos = "Indisa";
            this.con.NombreTabla = "Medico";
            this.con.CadenaConexion = "Data Source=LAPTOP-JVPSLRP5;Initial Catalog=Indisa;Integrated Security=True";
        }


        //busca un medico para login
        public Medico buscarMedico(String rut)
        {
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla +
                                 " WHERE rutM = '" + rut + "';";

            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];
            Medico auxMedico = new Medico();

            if (dt.Rows.Count > 0)
            {
                auxMedico.AuxRutM = Convert.ToString(dt.Rows[0]["rutM"]);
                auxMedico.Contrasena = Convert.ToString(dt.Rows[0]["contrasena"]);
            }
            else
            {
                auxMedico.AuxRutM = string.Empty;
                auxMedico.Contrasena = string.Empty;
            }

            return auxMedico;

        }


        //busca el nombre del medico ingresado para ponerlo en pantalla
        public Medico buscarNombresMedico(String rut)
        {
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT * FROM " + this.con.NombreTabla +
                                 " WHERE rutM = '" + rut + "';";

            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];
            Medico auxMedico = new Medico();

            if (dt.Rows.Count > 0)
            {
                Medico.Nombres = Convert.ToString(dt.Rows[0]["nombres"]) + " " +Convert.ToString(dt.Rows[0]["apellidos"]);
                Medico.Especialidad = Convert.ToString(dt.Rows[0]["especialidad"]);
            }
            else
            {
                auxMedico.AuxRutM = string.Empty;
                auxMedico.Contrasena = string.Empty;
            }

            return auxMedico;

        }
    }
}
