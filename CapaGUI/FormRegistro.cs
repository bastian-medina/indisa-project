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
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
            this.comboPrevision.Items.Insert(0, "Seleccionar");
            this.comboSexo.Items.Insert(0, "Seleccionar");
            this.comboSexo.SelectedIndex = 0;
            this.comboNacionalidad.SelectedIndex = 30;
            this.comboPrevision.SelectedIndex = 0;
        }

        
        //limpia cada vez que se guarda un paciente
        public void limpiarInputs()
        {
            this.txtRutPaciente.Text = "";
            this.txtPrimerNombre.Text = "";
            this.txtSegundoNombre.Text = "";
            this.txtApellidoMaterno.Text = "";
            this.txtApellidoPaterno.Text = "";
            this.comboNacionalidad.SelectedIndex = 30;
            this.comboSexo.SelectedIndex = 0;
            this.comboPrevision.SelectedIndex = 0;
            this.txtRutPaciente.Focus();
        }


        //boton que ingresa al paciente
        //verifica que los campos no esten vacios
        //verifica que el paciente no haya sido ingresado antes
        private void btnIngresarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtRutPaciente.Text) ||
                   String.IsNullOrEmpty(this.txtPrimerNombre.Text) ||
                   String.IsNullOrEmpty(this.txtSegundoNombre.Text) ||
                   String.IsNullOrEmpty(this.txtApellidoPaterno.Text) ||
                   String.IsNullOrEmpty(this.txtApellidoMaterno.Text) ||
                   this.comboPrevision.SelectedIndex == 0 ||
                   this.comboSexo.SelectedIndex == 0)
                {
                    MessageBox.Show("Ingrese los datos correctamente", "Mensaje del sistema");
                }
                else
                {

                    ServiceManPaciente.WebServiceMantenedorPacienteSoapClient auxNegocioPaciente = new ServiceManPaciente.WebServiceMantenedorPacienteSoapClient();
                    DateTime fecha = this.dateTimePickerNacimiento.Value;


                    if (String.IsNullOrEmpty(auxNegocioPaciente.webBuscarPaciente(this.txtRutPaciente.Text).RutP))
                    {

                        ServiceManPaciente.Paciente auxPaciente= new ServiceManPaciente.Paciente();

                        auxPaciente.RutP = this.txtRutPaciente.Text;
                        auxPaciente.Sexo = this.comboSexo.SelectedItem.ToString();
                        auxPaciente.PNombre = this.txtPrimerNombre.Text;
                        auxPaciente.SNombre = this.txtSegundoNombre.Text;
                        auxPaciente.ApellidoP = this.txtApellidoPaterno.Text;
                        auxPaciente.ApellidoM = this.txtApellidoMaterno.Text;
                        auxPaciente.FechaNacimiento = fecha;
                        auxPaciente.Nacionalidad = this.comboNacionalidad.SelectedItem.ToString();
                        auxPaciente.Prevision = this.comboPrevision.SelectedItem.ToString();

                        auxNegocioPaciente.webGuardarPaciente(auxPaciente);

                        MessageBox.Show("Paciente agregado", "Mensaje del sistema");
                        this.limpiarInputs();

                    }
                    else
                    {
                        MessageBox.Show("Paciente existente", "Mensaje del sistema");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "Mensaje del sistema");
            }
        }
    }
}
