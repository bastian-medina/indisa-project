
namespace CapaGUI
{
    partial class FormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresarPaciente = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboPrevision = new System.Windows.Forms.ComboBox();
            this.comboNacionalidad = new System.Windows.Forms.ComboBox();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRutPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerNacimiento);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnIngresarPaciente);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboPrevision);
            this.panel1.Controls.Add(this.comboNacionalidad);
            this.panel1.Controls.Add(this.comboSexo);
            this.panel1.Controls.Add(this.txtApellidoMaterno);
            this.panel1.Controls.Add(this.txtApellidoPaterno);
            this.panel1.Controls.Add(this.txtSegundoNombre);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPrimerNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRutPaciente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(629, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 585);
            this.panel1.TabIndex = 24;
            // 
            // dateTimePickerNacimiento
            // 
            this.dateTimePickerNacimiento.Location = new System.Drawing.Point(302, 306);
            this.dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
            this.dateTimePickerNacimiento.Size = new System.Drawing.Size(270, 22);
            this.dateTimePickerNacimiento.TabIndex = 45;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(420, 452);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(151, 34);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnIngresarPaciente
            // 
            this.btnIngresarPaciente.Location = new System.Drawing.Point(135, 452);
            this.btnIngresarPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarPaciente.Name = "btnIngresarPaciente";
            this.btnIngresarPaciente.Size = new System.Drawing.Size(151, 34);
            this.btnIngresarPaciente.TabIndex = 43;
            this.btnIngresarPaciente.Text = "Ingresar";
            this.btnIngresarPaciente.UseVisualStyleBackColor = true;
            this.btnIngresarPaciente.Click += new System.EventHandler(this.btnIngresarPaciente_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.label10.Location = new System.Drawing.Point(69, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(543, 54);
            this.label10.TabIndex = 42;
            this.label10.Text = "Ingreso de datos del cliente";
            // 
            // comboPrevision
            // 
            this.comboPrevision.FormattingEnabled = true;
            this.comboPrevision.Items.AddRange(new object[] {
            "Fonasa",
            "Isapre de Codelco",
            "Isapre Cruz Blanca",
            "Isapre Nueva MásVida",
            "Isapre Banmédica",
            "Isapre Vida Tres",
            "Isapre Colmena",
            "Isapre Consalud",
            "Isapre Cruz del Norte",
            "Isapre Fundación Banco Estado",
            "Particular"});
            this.comboPrevision.Location = new System.Drawing.Point(279, 374);
            this.comboPrevision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboPrevision.Name = "comboPrevision";
            this.comboPrevision.Size = new System.Drawing.Size(293, 24);
            this.comboPrevision.TabIndex = 41;
            // 
            // comboNacionalidad
            // 
            this.comboNacionalidad.FormattingEnabled = true;
            this.comboNacionalidad.Items.AddRange(new object[] {
            "Albania ",
            "Indonesia",
            "Alemania ",
            "Irak",
            "Angola ",
            "Irlanda (Eire)",
            "Antigua y Barbuda ",
            "Islas Feroe",
            "Argentina ",
            "Islas Vírgenes (Norteamericanas)",
            "Aruba ",
            "Israel",
            "Australia ",
            "Italia",
            "Bahamas ",
            "Jamaica",
            "Bangladesh ",
            "Japón",
            "Barbados ",
            "Letonia",
            "Bélgica ",
            "Líbano",
            "Belice ",
            "Malasia",
            "Bolivia ",
            "Martinica",
            "Brasil ",
            "México",
            "Canadá ",
            "Nicaragua",
            "Chile ",
            "Nigeria",
            "China (Continental) ",
            "Noruega",
            "China-Taiwán (Formosa) ",
            "Otras de las Indias Occidentales Británicas",
            "Colombia ",
            "Países Bajos",
            "Corea del Sur ",
            "Pakistán",
            "Costa Rica ",
            "Paraguay",
            "Cuba ",
            "Perú",
            "Curazao Polonia",
            "Dinamarca Portugal",
            "Dominica Puerto Rico",
            "Ecuador Reino Unido",
            "El Salvador República Dominicana",
            "Emiratos Árabes Unidos Rusia",
            "España San Martín (Parte Sur)",
            "Estados Unidos de América Santa Lucía",
            "Francia Sri Lanka",
            "Gambia Suecia",
            "Ghana Suiza",
            "Granada Suriname",
            "Grecia Tailandia",
            "Guadalupe y Dependencias Trinidad y Tobago",
            "Guatemala Turquía",
            "Guyana Uruguay",
            "Haití Venezuela",
            "Honduras Vietnam",
            "Hong Kong Zona Libre de Colón (Panamá)",
            "India",
            "Indonesia",
            "Irak",
            "Irlanda (Eire)",
            "Islas Feroe",
            "Islas Vírgenes (Norteamericanas)",
            "Israel",
            "Italia",
            "Jamaica",
            "Japón",
            "Letonia",
            "Líbano",
            "Malasia",
            "Martinica",
            "México",
            "Nicaragua",
            "Nigeria",
            "Noruega",
            "Otras de las Indias Occidentales Británicas",
            "Países Bajos",
            "Pakistán",
            "Paraguay",
            "Perú",
            "Polonia",
            "Portugal",
            "Puerto Rico",
            "Reino Unido",
            "República Dominicana",
            "Rusia",
            "San Martín (Parte Sur)",
            "Santa Lucía",
            "Sri Lanka",
            "Suecia",
            "Suiza",
            "Suriname",
            "Tailandia",
            "Trinidad y Tobago",
            "Turquía",
            "Uruguay",
            "Venezuela",
            "Vietnam",
            "Zona Libre de Colón (Panamá)"});
            this.comboNacionalidad.Location = new System.Drawing.Point(279, 341);
            this.comboNacionalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboNacionalidad.Name = "comboNacionalidad";
            this.comboNacionalidad.Size = new System.Drawing.Size(293, 24);
            this.comboNacionalidad.TabIndex = 40;
            // 
            // comboSexo
            // 
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.comboSexo.Location = new System.Drawing.Point(437, 136);
            this.comboSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(135, 24);
            this.comboSexo.TabIndex = 39;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(296, 276);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoMaterno.MaxLength = 30;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(276, 22);
            this.txtApellidoMaterno.TabIndex = 37;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(296, 241);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoPaterno.MaxLength = 30;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(276, 22);
            this.txtApellidoPaterno.TabIndex = 36;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(296, 208);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSegundoNombre.MaxLength = 30;
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(276, 22);
            this.txtSegundoNombre.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(129, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Previsión";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(129, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Nacionalidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(129, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(129, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(129, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(129, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Segundo Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Sexo";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(296, 175);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimerNombre.MaxLength = 30;
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(276, 22);
            this.txtPrimerNombre.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(129, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Primer Nombre";
            // 
            // txtRutPaciente
            // 
            this.txtRutPaciente.Location = new System.Drawing.Point(180, 140);
            this.txtRutPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRutPaciente.MaxLength = 10;
            this.txtRutPaciente.Name = "txtRutPaciente";
            this.txtRutPaciente.Size = new System.Drawing.Size(185, 22);
            this.txtRutPaciente.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(129, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Rut";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-27, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 524);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1316, 585);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRegistro";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIngresarPaciente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboPrevision;
        private System.Windows.Forms.ComboBox comboNacionalidad;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRutPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerNacimiento;
    }
}