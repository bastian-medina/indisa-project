
namespace CapaGUI
{
    partial class FormTratamiento
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
            this.boxMedicamento = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxTratamiento = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizarReceta = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRecetar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdControl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boxMedicamento
            // 
            this.boxMedicamento.BackColor = System.Drawing.SystemColors.Control;
            this.boxMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxMedicamento.Enabled = false;
            this.boxMedicamento.Location = new System.Drawing.Point(44, 112);
            this.boxMedicamento.Margin = new System.Windows.Forms.Padding(4);
            this.boxMedicamento.MaxLength = 100;
            this.boxMedicamento.Name = "boxMedicamento";
            this.boxMedicamento.Size = new System.Drawing.Size(435, 416);
            this.boxMedicamento.TabIndex = 76;
            this.boxMedicamento.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.label5.Location = new System.Drawing.Point(140, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 41);
            this.label5.TabIndex = 75;
            this.label5.Text = "Medicamentos";
            // 
            // boxTratamiento
            // 
            this.boxTratamiento.BackColor = System.Drawing.SystemColors.Control;
            this.boxTratamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxTratamiento.Enabled = false;
            this.boxTratamiento.Location = new System.Drawing.Point(535, 112);
            this.boxTratamiento.Margin = new System.Windows.Forms.Padding(4);
            this.boxTratamiento.MaxLength = 200;
            this.boxTratamiento.Name = "boxTratamiento";
            this.boxTratamiento.Size = new System.Drawing.Size(435, 416);
            this.boxTratamiento.TabIndex = 77;
            this.boxTratamiento.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(652, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 41);
            this.label1.TabIndex = 78;
            this.label1.Text = "Tratamientos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(1175, 425);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 44);
            this.btnCancelar.TabIndex = 79;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizarReceta
            // 
            this.btnFinalizarReceta.Enabled = false;
            this.btnFinalizarReceta.Location = new System.Drawing.Point(1027, 425);
            this.btnFinalizarReceta.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizarReceta.Name = "btnFinalizarReceta";
            this.btnFinalizarReceta.Size = new System.Drawing.Size(121, 44);
            this.btnFinalizarReceta.TabIndex = 80;
            this.btnFinalizarReceta.Text = "Finalizar Receta";
            this.btnFinalizarReceta.UseVisualStyleBackColor = true;
            this.btnFinalizarReceta.Click += new System.EventHandler(this.btnFinalizarReceta_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(1000, 263);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(88, 44);
            this.btnLeft.TabIndex = 81;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(1220, 263);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(88, 44);
            this.btnRight.TabIndex = 82;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // txtRut
            // 
            this.txtRut.Enabled = false;
            this.txtRut.Location = new System.Drawing.Point(1043, 82);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(216, 22);
            this.txtRut.TabIndex = 83;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(1043, 145);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 22);
            this.txtNombre.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1134, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Rut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1125, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 86;
            this.label3.Text = "Nombre";
            // 
            // btnRecetar
            // 
            this.btnRecetar.Location = new System.Drawing.Point(1112, 263);
            this.btnRecetar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecetar.Name = "btnRecetar";
            this.btnRecetar.Size = new System.Drawing.Size(88, 44);
            this.btnRecetar.TabIndex = 87;
            this.btnRecetar.Text = "Recetar";
            this.btnRecetar.UseVisualStyleBackColor = true;
            this.btnRecetar.Click += new System.EventHandler(this.btnRecetar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1125, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 88;
            this.label4.Text = "idControl";
            // 
            // txtIdControl
            // 
            this.txtIdControl.Enabled = false;
            this.txtIdControl.Location = new System.Drawing.Point(1043, 207);
            this.txtIdControl.Name = "txtIdControl";
            this.txtIdControl.Size = new System.Drawing.Size(216, 22);
            this.txtIdControl.TabIndex = 89;
            // 
            // FormTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1321, 572);
            this.Controls.Add(this.txtIdControl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRecetar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnFinalizarReceta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxTratamiento);
            this.Controls.Add(this.boxMedicamento);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTratamiento";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox boxMedicamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox boxTratamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizarReceta;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRecetar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdControl;
    }
}