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
    public class NegocioControl
    {

        private Conexion con;

        public Conexion Con { get => con; set => con = value; }


        public void configurarConexion()
        {
            this.con = new Conexion();
            this.con.NombreBaseDeDatos = "Indisa";
            this.con.NombreTabla = "Control";
            this.con.CadenaConexion = "Data Source=LAPTOP-JVPSLRP5;Initial Catalog=Indisa;Integrated Security=True";
        }


        //guarda un paciente
        public void guardarControl(Control control, String rutP, string rutM)
        {
            this.configurarConexion();

            this.con.CadenaSQL = "INSERT INTO " + this.con.NombreTabla +
                                  " (causa, prioridad, frecuenciaCardiaca, frecuenciaRespiratoria, presionArterial, saturacionO2, temperatura, dolor, fecha, rutP, rutM, estado) VALUES ('"
                                  + control.Causa + "','"
                                  + control.Prioridad + "','"
                                  + control.FrecuenciaCardiaca + "','"
                                  + control.FrecuenciaRespiratoria + "','"
                                  + control.PresionArterial + "','"
                                  + control.SaturacionO2 + "','"
                                  + control.Temperatura + "','"
                                  + control.Dolor + "','"
                                  + control.Fecha.ToString("yyyy-MM-dd") + "','"
                                  + rutP + "','"
                                  + rutM + "','"
                                  + control.Estado + "');";

            this.con.EsSelect = false;
            this.con.conectar();
        }


        //lista TODAS las consultas del paciente
        public DataSet listarHistorial(String rut)
        {
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT C.idControl, C.causa, M.nombres+ ' ' + M.apellidos  as nombre, C.fecha, c.prioridad FROM " + this.con.NombreTabla + " C "
                                 + " JOIN MEDICO M ON  C.rutM = M.rutM join paciente p on c.rutp = p.rutP"
                                 + " WHERE C.rutP  = '" + rut + "';";
            this.con.EsSelect = true;
            this.con.conectar();
            return this.con.DbDataSet;

        }


        //trae todas los datos de los que en control tiene su estado = "en espera"
        public Control listarActivosPantalla(int fila)
        {
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT C.idControl, C.rutP, P.PNOMBRE + ' ' + P.APELLIDOP  as nombre, C.causa, C.prioridad, C.presionArterial, C.temperatura, C.frecuenciaCardiaca FROM " + this.con.NombreTabla + " C "
                 + "  JOIN Paciente P ON  C.rutP = P.rutP  " +
                 " where c.estado = 'en espera';";

            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            Control auxControl = new Control();

            if (dt.Rows.Count > 0)
            {
                Paciente auxPaciente = new Paciente();
                auxPaciente.RutP = "";
                auxPaciente.PNombre = "";
                auxControl.AuxPaciente = auxPaciente;

                auxControl.AuxPaciente.RutP = Convert.ToString(dt.Rows[fila]["rutP"]);
                auxControl.AuxPaciente.PNombre = Convert.ToString(dt.Rows[fila]["nombre"]);
                auxControl.Causa = Convert.ToString(dt.Rows[fila]["causa"]);
                auxControl.Prioridad = Convert.ToString(dt.Rows[fila]["prioridad"]);
                auxControl.IdControl = Convert.ToString(dt.Rows[fila]["idControl"]);
                auxControl.PresionArterial = Convert.ToString(dt.Rows[fila]["presionArterial"]);
                auxControl.Temperatura = Convert.ToString(dt.Rows[fila]["temperatura"]);
                auxControl.FrecuenciaCardiaca = Convert.ToString(dt.Rows[fila]["frecuenciaCardiaca"]);
            }
            else
            {
                Paciente auxPaciente = new Paciente();
                auxPaciente.RutP = "";
                auxPaciente.PNombre = "";
                auxControl.AuxPaciente = auxPaciente;

                auxControl.AuxPaciente.RutP = String.Empty;
                auxControl.AuxPaciente.PNombre = String.Empty;
                auxControl.Causa = String.Empty;
                auxControl.Prioridad = String.Empty;
                auxControl.IdControl = String.Empty;
                auxControl.PresionArterial = String.Empty;
                auxControl.Temperatura = String.Empty;
                auxControl.FrecuenciaCardiaca = String.Empty;
            }
            return auxControl;


        }


        //trae todas los datos de los que en control tiene su estado = "en receta"
        public Control listarActivosPantallaReceta(int fila)
        {
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT C.idControl, C.rutP, P.PNOMBRE + ' ' + P.APELLIDOP  as nombre, C.causa, C.prioridad, C.presionArterial, C.temperatura, C.frecuenciaCardiaca FROM " + this.con.NombreTabla + " C "
                 + "  JOIN Paciente P ON  C.rutP = P.rutP  " +
                 " where c.estado = 'en receta';";

            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];

            Control auxControl = new Control();

            if (dt.Rows.Count > 0)
            {
                Paciente auxPaciente = new Paciente();
                auxPaciente.RutP = "";
                auxPaciente.PNombre = "";
                auxControl.AuxPaciente = auxPaciente;

                auxControl.AuxPaciente.RutP = Convert.ToString(dt.Rows[fila]["rutP"]);
                auxControl.AuxPaciente.PNombre = Convert.ToString(dt.Rows[fila]["nombre"]);
                auxControl.IdControl = Convert.ToString(dt.Rows[fila]["idControl"]);
            }
            else
            {
                Paciente auxPaciente = new Paciente();
                auxPaciente.RutP = "";
                auxPaciente.PNombre = "";
                auxControl.AuxPaciente = auxPaciente;

                auxControl.AuxPaciente.RutP = String.Empty;
                auxControl.AuxPaciente.PNombre = String.Empty;
                auxControl.IdControl = String.Empty;
            }
            return auxControl;


        }

        //trae todas los datos de los que en control tiene su estado = "en espera"
        //pero traidos en un dataset
        public DataSet listarActivos()
        {
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT C.rutP, P.PNOMBRE + ' ' + P.APELLIDOP  as nombre, C.causa, C.prioridad, C.presionArterial, C.temperatura, C.frecuenciaCardiaca FROM " + this.con.NombreTabla + " C "
                 + "  JOIN Paciente P ON  C.rutP = P.rutP  " +
                 " where c.estado = 'en espera';";
            this.Con.EsSelect = true;
            this.Con.conectar();
            return this.Con.DbDataSet;

        }


        //trae todas los datos de los que en control tiene su estado = "en receta"
        //pero traidos en un dataset
        public DataSet listarActivosReceta()
        {
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT C.rutP, P.PNOMBRE + ' ' + P.APELLIDOP  as nombre, C.causa, C.prioridad, C.presionArterial, C.temperatura, C.frecuenciaCardiaca FROM " + this.con.NombreTabla + " C "
                 + "  JOIN Paciente P ON  C.rutP = P.rutP  " +
                 " where c.estado = 'en receta';";
            this.Con.EsSelect = true;
            this.Con.conectar();
            return this.Con.DbDataSet;

        }
    }
}
