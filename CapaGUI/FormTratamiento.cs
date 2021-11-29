using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDTO;
using CapaNegocio;

namespace CapaGUI
{
    public partial class FormTratamiento : Form
    {

        private int posicion;
        private int ultimo;

        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }

        public FormTratamiento()
        {
            InitializeComponent();
            this.mostrar();
        }



        //metodo que habilita los botones
        public void habilitarBotonera()
        {
            this.btnRecetar.Enabled = true;
            this.btnLeft.Enabled = true;
            this.btnRight.Enabled = true;
        }


        //metodo que deshabilita los botones
        public void deshabilitarBotonera()
        {
            this.btnRecetar.Enabled = false;
            this.btnLeft.Enabled = false;
            this.btnRight.Enabled = false;
        }

        //metodo que habilita el diagnostico
        public void habilitarDiagnostico()
        {
            this.boxMedicamento.Enabled = true;
            this.boxTratamiento.Enabled = true;
            this.btnFinalizarReceta.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.boxMedicamento.Focus();
        }

        //metodo que deshabilita el diagnostico
        public void deshabilitarDiagnostico()
        {
            this.boxMedicamento.Enabled = false;
            this.boxTratamiento.Enabled = false;
            this.btnFinalizarReceta.Enabled = false;
            this.btnCancelar.Enabled = false;
        }


        //cuando aprieta recetar, descativa la botonera y habilita los medicamentos
        private void btnRecetar_Click(object sender, EventArgs e)
        {
            this.deshabilitarBotonera();
            this.habilitarDiagnostico();
        }

        //si aprieta cancelar, activa la botonera y deshabilita los medicamentos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.habilitarBotonera();
            this.deshabilitarDiagnostico();
        }

        //si aprieta el boton, resta 1 a posicion
        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.Posicion = this.Posicion - 1;
            this.mostrar();
        }

        //si aprieta el boton, suma 1 a posicion
        private void btnRight_Click(object sender, EventArgs e)
        {
            this.Posicion = this.Posicion + 1;
            this.mostrar();
        }

        //metodo que carga los datos de los pacientes que estan ingresados al diagnostico
        //tambien valida que los valores de posicion y ultimo no sean negativos
        public void mostrar()
        {
            ServiceManControl.WebServiceMantenedorControlSoapClient auxNegocioControl = new ServiceManControl.WebServiceMantenedorControlSoapClient();

            this.Ultimo = auxNegocioControl.webListarActivosReceta().Tables[0].Rows.Count - 1;

            ServiceManControl.Control auxControl = new ServiceManControl.Control();

            if (this.Posicion <= 0)
                this.Posicion = 0;
            if (this.Posicion >= this.Ultimo)
                this.Posicion = this.Ultimo;

            auxControl = auxNegocioControl.webListarActivosPantallaReceta(this.posicion);

            this.txtIdControl.Text = auxControl.IdControl;
            this.txtNombre.Text = auxControl.AuxPaciente.PNombre;
            this.txtRut.Text = auxControl.AuxPaciente.RutP;
        }


        //limpia los campos de texto
        public void limpiar()
        {
            this.boxTratamiento.Text = "";
            this.boxMedicamento.Text = "";
        }

        //si aprieta finalizar, guarda la consulta en la base de datos
        //verifica que no este vacio
        //y cuando guarda, deshabilita medicamentos y tratamiento, para activar la botonra
        private void btnFinalizarReceta_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(this.boxMedicamento.Text) ||
                    String.IsNullOrEmpty(this.boxTratamiento.Text))
                {
                    MessageBox.Show("Rellene los datos del paciente", "Mensaje del sistema");
                }
                else
                {
                    ServiceManReceta.WebServiceMantenedorRecetaSoapClient auxNegocioReceta = new ServiceManReceta.WebServiceMantenedorRecetaSoapClient();
                    ServiceManReceta.Receta auxReceta = new ServiceManReceta.Receta();

                    auxReceta.Medicamentos = this.boxMedicamento.Text;
                    auxReceta.Tratamientos = this.boxTratamiento.Text;


                    auxNegocioReceta.webGuardarReceta(auxReceta, this.txtIdControl.Text);
                    auxNegocioReceta.webCambiarEstadoConsulta(this.txtIdControl.Text,this.txtRut.Text);

                    MessageBox.Show("Receta finalizada", "Mensaje del sistema");

                    this.mostrar();
                    this.limpiar();
                    this.deshabilitarDiagnostico();
                    this.habilitarBotonera();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, intentelo mas tarde", "Mensaje del sistema");
            }
        }
    }
}
