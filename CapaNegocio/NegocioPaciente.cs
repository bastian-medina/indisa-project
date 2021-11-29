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
    public class NegocioPaciente
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void configurarConexion()
        {
            this.con = new Conexion();
            this.con.NombreBaseDeDatos = "Indisa";
            this.con.NombreTabla = "Paciente";
            this.con.CadenaConexion = "Data Source=LAPTOP-JVPSLRP5;Initial Catalog=Indisa;Integrated Security=True";
        }


        //guarda un paciente
        public void guardarPaciente(Paciente paciente)
        {
            this.configurarConexion();

            this.con.CadenaSQL = "INSERT INTO " + this.con.NombreTabla + 
                                  " (rutP, pNombre, sNombre, apellidoP, apellidoM, sexo, fechaNacimiento, nacionalidad, prevision) VALUES ('" 
                                  + paciente.RutP + "','"
                                  + paciente.PNombre + "','"
                                  + paciente.SNombre + "','"
                                  + paciente.ApellidoP + "','"
                                  + paciente.ApellidoM + "','"
                                  + paciente.Sexo + "','"
                                  + paciente.FechaNacimiento.ToString("yyyy-MM-dd") + "','"
                                  + paciente.Nacionalidad + "','"
                                  + paciente.Prevision +"');";

            this.con.EsSelect = false;
            this.con.conectar();
        }


        //busca los datos de un paciente
        //calcula su edad en base a la fecha actual y su fecha de nacimiento
        //estos datos van a parar al control
        public Paciente buscarPaciente(String rut)
        {
            this.configurarConexion();
            this.con.CadenaSQL = "SELECT datediff(yyyy, fechaNacimiento, getDate()) as anos, rutP, sexo, nacionalidad, pNombre, sNombre, apellidoP, apellidoM, prevision from " + this.con.NombreTabla + 
                                 " WHERE rutP = '" + rut + "';";

            this.con.EsSelect = true;
            this.con.conectar();

            DataTable dt = new DataTable();
            dt = this.con.DbDataSet.Tables[this.con.NombreTabla];
            Paciente auxPaciente = new Paciente();

            if (dt.Rows.Count > 0)
            {
                auxPaciente.RutP = Convert.ToString(dt.Rows[0]["rutP"]);
                auxPaciente.Sexo = Convert.ToString(dt.Rows[0]["sexo"]);
                auxPaciente.Anos = Convert.ToString(dt.Rows[0]["anos"]);
                auxPaciente.Nacionalidad = Convert.ToString(dt.Rows[0]["nacionalidad"]);
                auxPaciente.PNombre = Convert.ToString(dt.Rows[0]["pnombre"]);
                auxPaciente.SNombre = Convert.ToString(dt.Rows[0]["snombre"]);
                auxPaciente.ApellidoP = Convert.ToString(dt.Rows[0]["apellidoP"]);
                auxPaciente.ApellidoM = Convert.ToString(dt.Rows[0]["apellidom"]);
                auxPaciente.Prevision = Convert.ToString(dt.Rows[0]["prevision"]);
            }
            else
            {
                auxPaciente.RutP = string.Empty;
                auxPaciente.Sexo = string.Empty;
                auxPaciente.Anos = string.Empty;
                auxPaciente.Nacionalidad = string.Empty;
                auxPaciente.PNombre = string.Empty;
                auxPaciente.SNombre = string.Empty;
                auxPaciente.ApellidoP = string.Empty;
                auxPaciente.ApellidoM = string.Empty;
                auxPaciente.Prevision = string.Empty;
            }

            return auxPaciente;

        }



    }
}
