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
    public partial class FormControl : Form
    {
        public FormControl()
        {
            InitializeComponent();
        }


        //cada vez que se el form agrega y fija un valor al comboBox
        private void FormControl_Load(object sender, EventArgs e)
        {
            this.comboPrioridad.Items.Insert(0, "Seleccionar");
            this.comboPrioridad.SelectedIndex = 0;
        }


        //limpia cada vez que se guarda un control
        public void limpiar()
        {
            //info del paciente
            this.txtRutControl.Text = "";
            this.txtSexoControl.Text = "";
            this.txtEdadControl.Text = "";
            this.txtNacionalidadControl.Text = "";
            this.txtNombreControl.Text = "";
            this.txtPrevision.Text = "";

            //anamnesis
            this.txtFrecCardiaca.Text = "";
            this.txtPreArterial.Text = "";
            this.txtFrecRespiratoria.Text = "";
            this.txtSatOxigeno.Text = "";
            this.txtTemperatura.Text = "";
            this.txtDolor.Text = "";

            //info del caso
            this.txtCausa.Text = "";
            this.comboPrioridad.SelectedIndex = 0;

            //focus
            this.txtRutControl.Focus();
        }


        //boton que completa los datos del pacientes, para que el personal sepa 
        //el historial y la infomacion personal del paciente
        //Verifica que los campos no este vacios
        //verifica que el paciente exista
        //Completa los inupts y el DataGridView
        private void btnRellenar_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(this.txtRutControl.Text))
                {
                    MessageBox.Show("Rellene el rut", "Mensaje del sistema");
                }
                else
                {
                    ServiceManPaciente.WebServiceMantenedorPacienteSoapClient auxNegocioPaciente = new ServiceManPaciente.WebServiceMantenedorPacienteSoapClient();

                    if (String.IsNullOrEmpty(auxNegocioPaciente.webBuscarPaciente(this.txtRutControl.Text).RutP))
                    {
                        MessageBox.Show("Paciente inexistente", "Mensaje del sistema");
                    }
                    else
                    {
                        ServiceManControl.WebServiceMantenedorControlSoapClient auxNegocioControl = new ServiceManControl.WebServiceMantenedorControlSoapClient();
                        ServiceManPaciente.Paciente auxPaciente = new ServiceManPaciente.Paciente();

                        auxPaciente = auxNegocioPaciente.webBuscarPaciente(this.txtRutControl.Text);

                        this.txtSexoControl.Text = auxPaciente.Sexo;
                        this.txtEdadControl.Text = auxPaciente.Anos;
                        this.txtNacionalidadControl.Text = auxPaciente.Nacionalidad;
                        this.txtNombreControl.Text = auxPaciente.PNombre + " " + auxPaciente.SNombre + " " + auxPaciente.ApellidoP + " " + auxPaciente.ApellidoM;
                        this.txtPrevision.Text = auxPaciente.Prevision;


                        this.dataGridView1.DataSource = auxNegocioControl.webListarHistorial(this.txtRutControl.Text);
                        this.dataGridView1.DataMember = "control";


                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "Mensaje del sistema");
            }
        }

        
        //guarda los datos de la anamnesis para su eventual insercion en la base de datos
        private void btnGuardarAnam_Click(object sender, EventArgs e)
        {
            try
            {

                if(String.IsNullOrEmpty(this.txtFrecCardiaca.Text) ||
                   String.IsNullOrEmpty(this.txtPreArterial.Text) ||
                   String.IsNullOrEmpty(this.txtFrecRespiratoria.Text) ||
                   String.IsNullOrEmpty(this.txtSatOxigeno.Text) ||
                   String.IsNullOrEmpty(this.txtTemperatura.Text) ||
                   String.IsNullOrEmpty(this.txtDolor.Text))
                {
                    MessageBox.Show("Complete el anamnesis", "Mensaje del sistema");
                }
                else
                {
                     this.txtFrecCardiaca.Enabled = false;
                     this.txtPreArterial.Enabled = false;
                     this.txtFrecRespiratoria.Enabled = false;
                     this.txtSatOxigeno.Enabled = false;
                     this.txtTemperatura.Enabled = false;
                     this.txtDolor.Enabled = false;
                    MessageBox.Show("Anamnesis completado", "Mensaje del sistema");
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Algo ha ocurrido, intente nuevamente", "Mensaje del sistema");
            }
        }


        //habilita los inputs para la actualizacion de los datos de la anamnesis
        //verifica nuevamente que los datos no esten vacios
        private void btnModificarAnam_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(this.txtFrecCardiaca.Text) ||
                   String.IsNullOrEmpty(this.txtPreArterial.Text) ||
                   String.IsNullOrEmpty(this.txtFrecRespiratoria.Text) ||
                   String.IsNullOrEmpty(this.txtSatOxigeno.Text) ||
                   String.IsNullOrEmpty(this.txtTemperatura.Text) ||
                   String.IsNullOrEmpty(this.txtDolor.Text))
                {
                    MessageBox.Show("Complete el anamnesis", "Mensaje del sistema");
                }
                else
                {
                    this.txtFrecCardiaca.Enabled = true;
                    this.txtPreArterial.Enabled = true;
                    this.txtFrecRespiratoria.Enabled = true;
                    this.txtSatOxigeno.Enabled = true;
                    this.txtTemperatura.Enabled = true;
                    this.txtDolor.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo ha ocurrido, intente nuevamente", "Mensaje del sistema");
            }
        }

        
        //boton registrar control para su utilizacion en la base de datos
        //verifica que los datos no esten vacios
        private void btnRegistrarCaso_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtFrecCardiaca.Text) ||
                   String.IsNullOrEmpty(this.txtPreArterial.Text) ||
                   String.IsNullOrEmpty(this.txtFrecRespiratoria.Text) ||
                   String.IsNullOrEmpty(this.txtSatOxigeno.Text) ||
                   String.IsNullOrEmpty(this.txtTemperatura.Text) ||
                   String.IsNullOrEmpty(this.txtDolor.Text) ||
                   String.IsNullOrEmpty(this.txtCausa.Text) ||
                   String.IsNullOrEmpty(this.txtRutControl.Text) ||
                   this.comboPrioridad.SelectedIndex == 0)
                {
                    MessageBox.Show("Complete la informacion del caso", "Mensaje del sistema");
                }
                else
                {
                    ServiceManControl.WebServiceMantenedorControlSoapClient auxNegocioControl = new ServiceManControl.WebServiceMantenedorControlSoapClient();
                    ServiceManControl.Control auxControl = new ServiceManControl.Control();

                    String auxRut = this.txtRutControl.Text;
                    String auxRutM = Medico.RutM;

                    auxControl.Causa = this.txtCausa.Text;
                    auxControl.Prioridad = this.comboPrioridad.SelectedItem.ToString();
                    auxControl.FrecuenciaCardiaca = this.txtFrecCardiaca.Text;
                    auxControl.FrecuenciaRespiratoria = this.txtFrecRespiratoria.Text;
                    auxControl.PresionArterial = this.txtPreArterial.Text;
                    auxControl.SaturacionO2 = this.txtSatOxigeno.Text;
                    auxControl.Temperatura = this.txtTemperatura.Text;
                    auxControl.Dolor = this.txtTemperatura.Text;
                    auxControl.Fecha = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                    auxControl.Estado = "en espera";


                    auxNegocioControl.webGuardarControl(auxControl, auxRut, auxRutM);

                    this.txtFrecCardiaca.Enabled = true;
                    this.txtPreArterial.Enabled = true;
                    this.txtFrecRespiratoria.Enabled = true;
                    this.txtSatOxigeno.Enabled = true;
                    this.txtTemperatura.Enabled = true;
                    this.txtDolor.Enabled = true;

                    MessageBox.Show("Ingresado a sala de espera", "Mensaje del sistema");
                    this.limpiar();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, intente nuevamente", "Mensaje del sistema");
            }
        }


        //limita a los inputs
        //escribe solo numeros decimales del tipo  DOUBLE osea, decimales
        private void txtFrecCardiaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Si deseas, puedes permitir numeros decimales (o float)
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        //limita a los inputs
        //escribe solo numeros decimales del tipo  DOUBLE osea, decimales
        private void txtPreArterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Si deseas, puedes permitir numeros decimales (o float)
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        //limita a los inputs
        //escribe solo numeros decimales del tipo  DOUBLE osea, decimales
        private void txtFrecRespiratoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Si deseas, puedes permitir numeros decimales (o float)
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        //limita a los inputs
        //escribe solo numeros decimales del tipo  DOUBLE osea, decimales
        private void txtSatOxigeno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Si deseas, puedes permitir numeros decimales (o float)
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        //limita a los inputs
        //escribe solo numeros decimales del tipo  DOUBLE osea, decimales
        private void txtTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Si deseas, puedes permitir numeros decimales (o float)
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }



    }
}
