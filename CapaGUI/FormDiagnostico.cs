using CapaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class FormDiagnostico : Form
    {
        private int posicion;
        private int ultimo;

        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }


        public FormDiagnostico()
        {
            InitializeComponent();
            this.comboTipo.Items.Insert(0, "Seleccionar");
            this.comboTipo.SelectedIndex = 0;
        }

        
        //metodo que carga los datos de los pacientes que estan ingresados al control 
        //tambien valida que los valores de posicion y ultimo no sean negativos
        public void mostrar()
        {

            ServiceManControl.WebServiceMantenedorControlSoapClient auxNegocioControl = new ServiceManControl.WebServiceMantenedorControlSoapClient();

            this.Ultimo = auxNegocioControl.webListarActivos().Tables[0].Rows.Count - 1;

            ServiceManControl.Control auxControl = new ServiceManControl.Control();

            if (this.Posicion <= 0)
                this.Posicion = 0;
            if (this.Posicion >= this.Ultimo)
                this.Posicion = this.Ultimo;

            auxControl = auxNegocioControl.webListarActivosPantalla(this.posicion);

            this.txtRutDiagnostico.Text = auxControl.AuxPaciente.RutP;
            //contiene todo el nombre
            this.txtNombre.Text = auxControl.AuxPaciente.PNombre;
            this.txtCausa.Text = auxControl.Causa;
            this.txtPrioridad.Text = auxControl.Prioridad;
            this.txtPresion.Text = auxControl.PresionArterial;
            this.txtFreCardiaca.Text = auxControl.FrecuenciaCardiaca;
            this.txtTemperatura.Text = auxControl.Temperatura;
            this.txtIdControl.Text = auxControl.IdControl;
        }


        //si aprieta, resta 1 a posicion
        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.Posicion = this.Posicion - 1;
            this.mostrar();
        }

        //si aprieta, suma 1 a posicion
        private void btnRight_Click(object sender, EventArgs e)
        {
            this.Posicion = this.Posicion + 1;
            this.mostrar();
        }


        //cada vez que carga el formulario, deshabilita la edicion del diagnostico
        private void FormDiagnostico_Load(object sender, EventArgs e)
        {
            this.mostrar();
            this.deshabilitarDiagnostico();
        }


        //metodo que habilita el diagnostico 
        public void habilitarDiagnostico()
        {
            this.richTextBox1.Enabled = true;
            this.comboTipo.Enabled = true;
            this.btnDiagnosticar.Enabled = true;
            this.btnCancelarDiag.Enabled = true;
        }


        //metodo que deshabilita el diagnostico 
        public void deshabilitarDiagnostico()
        {
            this.richTextBox1.Enabled = false;
            this.comboTipo.Enabled = false;
            this.btnDiagnosticar.Enabled = false;
            this.btnCancelarDiag.Enabled = false;
        }


        //metodo que habilita la botonera
        public void habilitarBotonera()
        {
            this.btnAtender.Enabled = true;
            this.btnLeft.Enabled = true;
            this.btnRight.Enabled = true;
        }


        //metodo que deshabilita la botonera
        public void deshabilitarBotonera()
        {
            this.btnAtender.Enabled = false;
            this.btnLeft.Enabled = false;
            this.btnRight.Enabled = false;
        }


        //cuando aprieta atender, se deshabilita la botonera y activa el form diagnostico
        private void btnAtender_Click(object sender, EventArgs e)
        {
            this.deshabilitarBotonera();
            this.habilitarDiagnostico();
        }

        //cuando aprieta cancelar, se habilita la botonera y desactiva el form diagnostico
        private void btnCancelarDiag_Click(object sender, EventArgs e)
        {
            this.habilitarBotonera();
            this.deshabilitarDiagnostico();
            this.richTextBox1.Text = "";
        }


        //boton que guarda en la base de datos el diagnostico y su tipo
        //verifica que los campos no esten vacios
        //si lo guarda, activa la botonera, limpia el diagnostico y lo bloquea
        private void btnDiagnosticar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(this.richTextBox1.Text) ||
                   this.comboTipo.SelectedIndex == 0)
                {
                    MessageBox.Show("Complete los campos", "Mensaje del sistema");
                }
                else
                {
                    ServiceManDiagnostico.WebServiceMantenedorDiagnosticoSoapClient auxNegocioDiagnostico = new ServiceManDiagnostico.WebServiceMantenedorDiagnosticoSoapClient();
                    ServiceManDiagnostico.Diagnostico auxDiagnostico = new ServiceManDiagnostico.Diagnostico();


                    auxDiagnostico.DiagnosticoConsulta = this.richTextBox1.Text;
                    auxNegocioDiagnostico.webGuardarDiagnostico(auxDiagnostico, this.txtIdControl.Text, this.comboTipo.SelectedItem.ToString());
                    auxNegocioDiagnostico.webCambiarEstadoConsulta(this.txtIdControl.Text, this.txtRutDiagnostico.Text);

                    MessageBox.Show("Consulta acabada", "Mensaje del sistema");

                    this.limpiarDiagnostico();
                    this.habilitarBotonera();
                    this.deshabilitarDiagnostico();
                    this.mostrar();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, intentelo nuevamente", "Mensaje del sistema");
            }
        }


        //limpia los campos richBox
        public void limpiarDiagnostico()
        {
            this.richTextBox1.Text = "";
            this.comboTipo.SelectedIndex = 0;
        }
    }
}
