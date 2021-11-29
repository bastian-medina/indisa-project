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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.txtClave.PasswordChar = '*';
        }
        
        //evento del boton Login
        //verifica que los campos no esten vacios
        //verrifica que el medico exista
        //verifica que la contraseña sea correcta
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(this.txtRutMedico.Text) ||
                   String.IsNullOrEmpty(this.txtClave.Text))
                {
                    MessageBox.Show("Ingrese los datos correctamente", "Mensaje del sistema");
                    this.txtRutMedico.Focus();
                }
                else
                {
                    //ServiceMantenedorMedico.WebServiceMantenedorMedicoSoapClient auxNegocioMedico = new ServiceMantenedorMedico.WebServiceMantenedorMedicoSoapClient();
                    ServiceManMedico.WebServiceMantenedorMedicoSoapClient auxNegocioMedico = new ServiceManMedico.WebServiceMantenedorMedicoSoapClient();


                    if (String.IsNullOrEmpty(auxNegocioMedico.webBuscarMedico(this.txtRutMedico.Text).AuxRutM))
                    {
                        MessageBox.Show("Medico inexistente", "Mensaje sistema");
                    }
                    else
                    {
                        //ServiceMantenedorMedico.Medico auxMedico = new ServiceMantenedorMedico.Medico();
                        ServiceManMedico.Medico auxMedico = new ServiceManMedico.Medico();

                        auxMedico = auxNegocioMedico.webBuscarMedico(this.txtRutMedico.Text);

                        if(this.txtRutMedico.Text == auxMedico.AuxRutM && this.txtClave.Text == auxMedico.Contrasena)
                        {
                            Medico.RutM = this.txtRutMedico.Text;


                            Menu menu = new Menu();
                            menu.ShowDialog();

                            this.Close();


                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta", "Mensaje sistema");
                        }

                    }

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "Mensaje del sistema");
            }
        }
    }
}
