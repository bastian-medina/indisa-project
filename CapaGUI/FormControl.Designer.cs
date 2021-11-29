
namespace CapaGUI
{
    partial class FormControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistrarCaso = new System.Windows.Forms.Button();
            this.comboPrioridad = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCausa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModificarAnam = new System.Windows.Forms.Button();
            this.btnGuardarAnam = new System.Windows.Forms.Button();
            this.txtDolor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSatOxigeno = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFrecRespiratoria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPreArterial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFrecCardiaca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRellenar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrevision = new System.Windows.Forms.TextBox();
            this.txtRutControl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreControl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSexoControl = new System.Windows.Forms.TextBox();
            this.txtNacionalidadControl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEdadControl = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnRegistrarCaso);
            this.panel2.Controls.Add(this.comboPrioridad);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtCausa);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 282);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1321, 290);
            this.panel2.TabIndex = 13;
            // 
            // btnRegistrarCaso
            // 
            this.btnRegistrarCaso.Location = new System.Drawing.Point(47, 180);
            this.btnRegistrarCaso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarCaso.Name = "btnRegistrarCaso";
            this.btnRegistrarCaso.Size = new System.Drawing.Size(169, 33);
            this.btnRegistrarCaso.TabIndex = 94;
            this.btnRegistrarCaso.Text = "Registrar";
            this.btnRegistrarCaso.UseVisualStyleBackColor = true;
            this.btnRegistrarCaso.Click += new System.EventHandler(this.btnRegistrarCaso_Click);
            // 
            // comboPrioridad
            // 
            this.comboPrioridad.FormattingEnabled = true;
            this.comboPrioridad.Items.AddRange(new object[] {
            "Baja",
            "Media",
            "Alta",
            "Muy Alta"});
            this.comboPrioridad.Location = new System.Drawing.Point(137, 102);
            this.comboPrioridad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboPrioridad.Name = "comboPrioridad";
            this.comboPrioridad.Size = new System.Drawing.Size(413, 24);
            this.comboPrioridad.TabIndex = 68;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.label15.Location = new System.Drawing.Point(155, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(316, 41);
            this.label15.TabIndex = 67;
            this.label15.Text = "Información del Caso";
            // 
            // txtCausa
            // 
            this.txtCausa.Location = new System.Drawing.Point(107, 66);
            this.txtCausa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCausa.MaxLength = 100;
            this.txtCausa.Name = "txtCausa";
            this.txtCausa.Size = new System.Drawing.Size(445, 22);
            this.txtCausa.TabIndex = 64;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 17);
            this.label16.TabIndex = 63;
            this.label16.Text = "Causa";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(43, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 17);
            this.label17.TabIndex = 65;
            this.label17.Text = "Prioridad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(594, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(752, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnModificarAnam);
            this.panel1.Controls.Add(this.btnGuardarAnam);
            this.panel1.Controls.Add(this.txtDolor);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtTemperatura);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtSatOxigeno);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtFrecRespiratoria);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtPreArterial);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtFrecCardiaca);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnRellenar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPrevision);
            this.panel1.Controls.Add(this.txtRutControl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombreControl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSexoControl);
            this.panel1.Controls.Add(this.txtNacionalidadControl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEdadControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 276);
            this.panel1.TabIndex = 14;
            // 
            // btnModificarAnam
            // 
            this.btnModificarAnam.Location = new System.Drawing.Point(1087, 219);
            this.btnModificarAnam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarAnam.Name = "btnModificarAnam";
            this.btnModificarAnam.Size = new System.Drawing.Size(188, 33);
            this.btnModificarAnam.TabIndex = 93;
            this.btnModificarAnam.Text = "Modificar";
            this.btnModificarAnam.UseVisualStyleBackColor = true;
            this.btnModificarAnam.Click += new System.EventHandler(this.btnModificarAnam_Click);
            // 
            // btnGuardarAnam
            // 
            this.btnGuardarAnam.Location = new System.Drawing.Point(892, 219);
            this.btnGuardarAnam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarAnam.Name = "btnGuardarAnam";
            this.btnGuardarAnam.Size = new System.Drawing.Size(169, 33);
            this.btnGuardarAnam.TabIndex = 79;
            this.btnGuardarAnam.Text = "Guardar";
            this.btnGuardarAnam.UseVisualStyleBackColor = true;
            this.btnGuardarAnam.Click += new System.EventHandler(this.btnGuardarAnam_Click);
            // 
            // txtDolor
            // 
            this.txtDolor.Location = new System.Drawing.Point(1171, 162);
            this.txtDolor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDolor.MaxLength = 10;
            this.txtDolor.Name = "txtDolor";
            this.txtDolor.Size = new System.Drawing.Size(64, 22);
            this.txtDolor.TabIndex = 92;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1180, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 17);
            this.label14.TabIndex = 91;
            this.label14.Text = "Dolor";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(1037, 162);
            this.txtTemperatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTemperatura.MaxLength = 10;
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(64, 22);
            this.txtTemperatura.TabIndex = 90;
            this.txtTemperatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemperatura_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1020, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 17);
            this.label13.TabIndex = 89;
            this.label13.Text = "Temperatura";
            // 
            // txtSatOxigeno
            // 
            this.txtSatOxigeno.Location = new System.Drawing.Point(905, 162);
            this.txtSatOxigeno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSatOxigeno.MaxLength = 10;
            this.txtSatOxigeno.Name = "txtSatOxigeno";
            this.txtSatOxigeno.Size = new System.Drawing.Size(64, 22);
            this.txtSatOxigeno.TabIndex = 88;
            this.txtSatOxigeno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatOxigeno_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(889, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 17);
            this.label12.TabIndex = 87;
            this.label12.Text = "Sat. Oxigeno";
            // 
            // txtFrecRespiratoria
            // 
            this.txtFrecRespiratoria.Location = new System.Drawing.Point(1171, 97);
            this.txtFrecRespiratoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFrecRespiratoria.MaxLength = 10;
            this.txtFrecRespiratoria.Name = "txtFrecRespiratoria";
            this.txtFrecRespiratoria.Size = new System.Drawing.Size(64, 22);
            this.txtFrecRespiratoria.TabIndex = 86;
            this.txtFrecRespiratoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrecRespiratoria_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1153, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 17);
            this.label11.TabIndex = 85;
            this.label11.Text = "Frec. Respiratoria";
            // 
            // txtPreArterial
            // 
            this.txtPreArterial.Location = new System.Drawing.Point(1037, 97);
            this.txtPreArterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPreArterial.MaxLength = 10;
            this.txtPreArterial.Name = "txtPreArterial";
            this.txtPreArterial.Size = new System.Drawing.Size(64, 22);
            this.txtPreArterial.TabIndex = 84;
            this.txtPreArterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreArterial_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1020, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 83;
            this.label10.Text = "Presión Arterial";
            // 
            // txtFrecCardiaca
            // 
            this.txtFrecCardiaca.Location = new System.Drawing.Point(905, 97);
            this.txtFrecCardiaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFrecCardiaca.MaxLength = 10;
            this.txtFrecCardiaca.Name = "txtFrecCardiaca";
            this.txtFrecCardiaca.Size = new System.Drawing.Size(64, 22);
            this.txtFrecCardiaca.TabIndex = 82;
            this.txtFrecCardiaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrecCardiaca_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(889, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 81;
            this.label9.Text = "Frec. Cardiaca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.label8.Location = new System.Drawing.Point(991, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 41);
            this.label8.TabIndex = 80;
            this.label8.Text = "Anamnesis";
            // 
            // btnRellenar
            // 
            this.btnRellenar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRellenar.Location = new System.Drawing.Point(39, 209);
            this.btnRellenar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(225, 33);
            this.btnRellenar.TabIndex = 63;
            this.btnRellenar.Text = "Rellenar";
            this.btnRellenar.UseVisualStyleBackColor = true;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.label7.Location = new System.Drawing.Point(232, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(368, 41);
            this.label7.TabIndex = 62;
            this.label7.Text = "Información del Paciente";
            // 
            // txtPrevision
            // 
            this.txtPrevision.Enabled = false;
            this.txtPrevision.Location = new System.Drawing.Point(479, 148);
            this.txtPrevision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrevision.Name = "txtPrevision";
            this.txtPrevision.Size = new System.Drawing.Size(169, 22);
            this.txtPrevision.TabIndex = 61;
            // 
            // txtRutControl
            // 
            this.txtRutControl.Location = new System.Drawing.Point(69, 95);
            this.txtRutControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRutControl.MaxLength = 10;
            this.txtRutControl.Name = "txtRutControl";
            this.txtRutControl.Size = new System.Drawing.Size(165, 22);
            this.txtRutControl.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 60;
            this.label6.Text = "Previsión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Rut";
            // 
            // txtNombreControl
            // 
            this.txtNombreControl.Enabled = false;
            this.txtNombreControl.Location = new System.Drawing.Point(176, 148);
            this.txtNombreControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreControl.Name = "txtNombreControl";
            this.txtNombreControl.Size = new System.Drawing.Size(205, 22);
            this.txtNombreControl.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Nombre Completo";
            // 
            // txtSexoControl
            // 
            this.txtSexoControl.Enabled = false;
            this.txtSexoControl.Location = new System.Drawing.Point(300, 95);
            this.txtSexoControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSexoControl.Name = "txtSexoControl";
            this.txtSexoControl.Size = new System.Drawing.Size(83, 22);
            this.txtSexoControl.TabIndex = 53;
            // 
            // txtNacionalidadControl
            // 
            this.txtNacionalidadControl.Enabled = false;
            this.txtNacionalidadControl.Location = new System.Drawing.Point(649, 96);
            this.txtNacionalidadControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNacionalidadControl.Name = "txtNacionalidadControl";
            this.txtNacionalidadControl.Size = new System.Drawing.Size(153, 22);
            this.txtNacionalidadControl.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Nacionalidad";
            // 
            // txtEdadControl
            // 
            this.txtEdadControl.Enabled = false;
            this.txtEdadControl.Location = new System.Drawing.Point(452, 96);
            this.txtEdadControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdadControl.Name = "txtEdadControl";
            this.txtEdadControl.Size = new System.Drawing.Size(83, 22);
            this.txtEdadControl.TabIndex = 55;
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormControl";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormControl_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModificarAnam;
        private System.Windows.Forms.Button btnGuardarAnam;
        private System.Windows.Forms.TextBox txtDolor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSatOxigeno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFrecRespiratoria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPreArterial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFrecCardiaca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrevision;
        private System.Windows.Forms.TextBox txtRutControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSexoControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEdadControl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCausa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegistrarCaso;
        private System.Windows.Forms.ComboBox comboPrioridad;
        private System.Windows.Forms.TextBox txtNacionalidadControl;
    }
}