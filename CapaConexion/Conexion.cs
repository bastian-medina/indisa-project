using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaConexion
{
    public class Conexion
    {

        //Varibles de instancia
        private String nombreBaseDeDatos;

        public String NombreBaseDeDatos
        {
            get { return nombreBaseDeDatos; }
            set { nombreBaseDeDatos = value; }
        }

        private String nombreTabla;

        public String NombreTabla
        {
            get { return nombreTabla; }
            set { nombreTabla = value; }
        }

        private String cadenaConexion;

        public String CadenaConexion
        {
            get { return cadenaConexion; }
            set { cadenaConexion = value; }
        }

        private String cadenaSQL;

        public String CadenaSQL
        {
            get { return cadenaSQL; }
            set { cadenaSQL = value; }
        }

        private Boolean esSelect;

        public Boolean EsSelect
        {
            get { return esSelect; }
            set { esSelect = value; }
        }

        private SqlConnection dbConnection;

        public SqlConnection DbConnection
        {
            get { return dbConnection; }
            set { dbConnection = value; }
        }

        private System.Data.DataSet dbDataSet;

        public System.Data.DataSet DbDataSet
        {
            get { return dbDataSet; }
            set { dbDataSet = value; }
        }


        private SqlDataAdapter dbDataAdapter;

        public SqlDataAdapter DbDataAdapter
        {
            get { return dbDataAdapter; }
            set { dbDataAdapter = value; }
        }


        //abrir la conexion

        public void abrir()
        {
            try
            {
                this.DbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexion " + ex.Message, "mensaje Sistema");
            }
        
        } //Fin abrir

        //Cerra la conexion

        public void cerrar()
        {
            try
            {
                this.DbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexion " + ex.Message, "mensaje Sistema");
            }

        } //Fin cerrar

        //Metodo mas importante

        public void conectar()
        {
            //Se validan las variables de   
            if (this.NombreBaseDeDatos.Length == 0)
            {
                MessageBox.Show("Falta nombre base de datos ", "mensaje Sistema");
                return;
            }


            if (this.NombreTabla.Length == 0)
            {
                MessageBox.Show("Falta nombre tabla ", "mensaje Sistema");
                return;
            }

            if (this.CadenaConexion.Length == 0)
            {
                MessageBox.Show("Falta cadena C ", "mensajeonexion Sistema");
                return;
            }
            if (this.CadenaSQL.Length == 0)
            {
                MessageBox.Show("Falta cadena SQL ", "mensaje Sistema");
                return;
            }
        
            //SE instancia la Conexion

            try
            {
                this.DbConnection = new SqlConnection(this.CadenaConexion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Conexion " + ex.Message, "mensaje Sistema");
                return;
            }

            //SE abre la conexion
            this.abrir();

            //Se instancia el DataAdapter

            if (this.EsSelect)
            {
                //SE instancia dataSet

                this.DbDataSet = new System.Data.DataSet();
                try
                {
                    this.DbDataAdapter = new SqlDataAdapter(this.CadenaSQL, this.DbConnection);
                    this.DbDataAdapter.Fill(this.DbDataSet, this.NombreTabla);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos " + ex.Message, "mensaje Sistema");
                    return;

                }
            }
            else
            {
                try
                {
                    SqlCommand variableSQL = new SqlCommand(this.CadenaSQL, this.DbConnection);
                    variableSQL.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en SQL " + ex.Message, "mensaje Sistema");
                    return;

                }
            } //Fin if



            this.cerrar();

        } //Fin conectar

        /*   public static void Main(String[] args)
           {

               Conexion conec1 = new Conexion();
               conec1.NombreBaseDeDatos = "prueba";
               conec1.NombreTabla = "cliente";
               conec1.CadenaConexion = "Data Source=LAPTOP-JVPSLRP5;Initial Catalog=indisa;Integrated Security=True";
               conec1.CadenaSQL ="select * from cliente";
               conec1.EsSelect = true;
               conec1.conectar();

               foreach (System.Data.DataRow dr in conec1.dbDataSet.Tables[conec1.NombreTabla].Rows)
               {
                   Console.WriteLine(dr["rut"] +" " + dr["nombre"]);
               }

           }*/



    }
}
