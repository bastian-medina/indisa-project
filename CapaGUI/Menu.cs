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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                AbrirFormulario<FormControl>();
            btnControl.BackColor = Color.White;
            btnControl.ForeColor= Color.Black;
            BtnRegistroCli.ForeColor = Color.White;
            btnDiagnosticoForm.ForeColor = Color.White;
            btnTratamientoForm.ForeColor = Color.White;
            BtnRegistroCli.BackColor = Color.FromArgb(2, 160, 223);
            btnDiagnosticoForm.BackColor = Color.FromArgb(2, 160, 223);
            btnTratamientoForm.BackColor = Color.FromArgb(2, 160, 223);
        }

        private void BtnRegistroCli_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormRegistro>();
            BtnRegistroCli.BackColor = Color.White;
            BtnRegistroCli.ForeColor = Color.Black;
            btnControl.ForeColor = Color.White;
            btnDiagnosticoForm.ForeColor = Color.White;
            btnTratamientoForm.ForeColor = Color.White;
            btnControl.BackColor = Color.FromArgb(2, 160, 223);
            btnDiagnosticoForm.BackColor = Color.FromArgb(2, 160, 223);
            btnTratamientoForm.BackColor = Color.FromArgb(2, 160, 223);
        }

        private void btnDiagnosticoForm_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormDiagnostico>();
            btnDiagnosticoForm.BackColor = Color.White;
            btnDiagnosticoForm.ForeColor = Color.Black;
            btnControl.ForeColor = Color.White;
            BtnRegistroCli.ForeColor = Color.White;
            btnTratamientoForm.ForeColor = Color.White;
            BtnRegistroCli.BackColor = Color.FromArgb(2, 160, 223);
            btnControl.BackColor = Color.FromArgb(2, 160, 223);
            btnTratamientoForm.BackColor = Color.FromArgb(2, 160, 223);
        }

        private void btnTratamientoForm_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormTratamiento>();
            btnTratamientoForm.BackColor = Color.White;
            btnTratamientoForm.ForeColor = Color.Black;
            btnControl.ForeColor = Color.White;
            BtnRegistroCli.ForeColor = Color.White;
            btnDiagnosticoForm.ForeColor = Color.White;
            btnDiagnosticoForm.BackColor = Color.FromArgb(2, 160, 223);
            BtnRegistroCli.BackColor = Color.FromArgb(2, 160, 223);
            btnControl.BackColor = Color.FromArgb(2, 160, 223);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            AbrirFormulario<FormRegistro>();
            BtnRegistroCli.BackColor = Color.White;
            BtnRegistroCli.ForeColor = Color.Black;

            NegocioMedico auxNegocioMedico = new NegocioMedico();
            auxNegocioMedico.buscarNombresMedico(Medico.RutM);
            this.txtRutMedico.Text = Medico.RutM;
            this.txtNombreMedicoMenu.Text = Medico.Nombres;
            this.txtEspecialidad.Text = Medico.Especialidad;
        }

        private void txtNombreMedicoMenu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();

            FormLogin auxFormLogin = new FormLogin();
            auxFormLogin.ShowDialog();
        }
    }
}
