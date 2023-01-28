namespace Proyecto_Bases_de_Datos_I
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbRegComputador = new System.Windows.Forms.TabPage();
            this.btnRegComputador = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtTipoDisco = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.tabRegEmpresa = new System.Windows.Forms.TabPage();
            this.btnRegEmpresa = new System.Windows.Forms.Button();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNitEmpresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbReparar = new System.Windows.Forms.TabPage();
            this.tbControl.SuspendLayout();
            this.tbRegComputador.SuspendLayout();
            this.tabRegEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbRegComputador);
            this.tbControl.Controls.Add(this.tabRegEmpresa);
            this.tbControl.Controls.Add(this.tbReparar);
            this.tbControl.Location = new System.Drawing.Point(-1, -1);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(802, 450);
            this.tbControl.TabIndex = 0;
            // 
            // tbRegComputador
            // 
            this.tbRegComputador.Controls.Add(this.btnRegComputador);
            this.tbRegComputador.Controls.Add(this.label4);
            this.tbRegComputador.Controls.Add(this.label3);
            this.tbRegComputador.Controls.Add(this.label2);
            this.tbRegComputador.Controls.Add(this.label1);
            this.tbRegComputador.Controls.Add(this.cbMarca);
            this.tbRegComputador.Controls.Add(this.txtCapacidad);
            this.tbRegComputador.Controls.Add(this.txtTipoDisco);
            this.tbRegComputador.Controls.Add(this.txtSerial);
            this.tbRegComputador.Location = new System.Drawing.Point(4, 24);
            this.tbRegComputador.Name = "tbRegComputador";
            this.tbRegComputador.Padding = new System.Windows.Forms.Padding(3);
            this.tbRegComputador.Size = new System.Drawing.Size(794, 422);
            this.tbRegComputador.TabIndex = 0;
            this.tbRegComputador.Text = "Registrar computador";
            this.tbRegComputador.UseVisualStyleBackColor = true;
            // 
            // btnRegComputador
            // 
            this.btnRegComputador.Location = new System.Drawing.Point(329, 372);
            this.btnRegComputador.Name = "btnRegComputador";
            this.btnRegComputador.Size = new System.Drawing.Size(75, 23);
            this.btnRegComputador.TabIndex = 8;
            this.btnRegComputador.Text = "Registrar";
            this.btnRegComputador.UseVisualStyleBackColor = true;
            this.btnRegComputador.Click += new System.EventHandler(this.btnRegComputador_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingrese el tipo de disco de almacenamiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese la capacidad del disco de almacenamiento (en Gigabytes):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione la marca del computador: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(223, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el serial del computador: ";
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Lenovo",
            "Dell",
            "Asus"});
            this.cbMarca.Location = new System.Drawing.Point(223, 147);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(255, 23);
            this.cbMarca.TabIndex = 3;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(223, 220);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(255, 23);
            this.txtCapacidad.TabIndex = 2;
            // 
            // txtTipoDisco
            // 
            this.txtTipoDisco.Location = new System.Drawing.Point(223, 290);
            this.txtTipoDisco.Name = "txtTipoDisco";
            this.txtTipoDisco.Size = new System.Drawing.Size(255, 23);
            this.txtTipoDisco.TabIndex = 1;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(223, 77);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(255, 23);
            this.txtSerial.TabIndex = 0;
            // 
            // tabRegEmpresa
            // 
            this.tabRegEmpresa.Controls.Add(this.btnRegEmpresa);
            this.tabRegEmpresa.Controls.Add(this.txtNombreEmpresa);
            this.tabRegEmpresa.Controls.Add(this.label6);
            this.tabRegEmpresa.Controls.Add(this.txtNitEmpresa);
            this.tabRegEmpresa.Controls.Add(this.label5);
            this.tabRegEmpresa.Location = new System.Drawing.Point(4, 24);
            this.tabRegEmpresa.Name = "tabRegEmpresa";
            this.tabRegEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegEmpresa.Size = new System.Drawing.Size(794, 422);
            this.tabRegEmpresa.TabIndex = 1;
            this.tabRegEmpresa.Text = "Registrar empresa";
            this.tabRegEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnRegEmpresa
            // 
            this.btnRegEmpresa.Location = new System.Drawing.Point(326, 297);
            this.btnRegEmpresa.Name = "btnRegEmpresa";
            this.btnRegEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnRegEmpresa.TabIndex = 4;
            this.btnRegEmpresa.Text = "Registrar";
            this.btnRegEmpresa.UseVisualStyleBackColor = true;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(244, 216);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(238, 23);
            this.txtNombreEmpresa.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ingrese el nombre de la empresa:";
            // 
            // txtNitEmpresa
            // 
            this.txtNitEmpresa.Location = new System.Drawing.Point(244, 129);
            this.txtNitEmpresa.Name = "txtNitEmpresa";
            this.txtNitEmpresa.Size = new System.Drawing.Size(238, 23);
            this.txtNitEmpresa.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ingrese el NIT de la empresa:";
            // 
            // tbReparar
            // 
            this.tbReparar.Location = new System.Drawing.Point(4, 24);
            this.tbReparar.Name = "tbReparar";
            this.tbReparar.Padding = new System.Windows.Forms.Padding(3);
            this.tbReparar.Size = new System.Drawing.Size(794, 422);
            this.tbReparar.TabIndex = 2;
            this.tbReparar.Text = "Reparar computador";
            this.tbReparar.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbControl);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbControl.ResumeLayout(false);
            this.tbRegComputador.ResumeLayout(false);
            this.tbRegComputador.PerformLayout();
            this.tabRegEmpresa.ResumeLayout(false);
            this.tabRegEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbControl;
        private TabPage tbRegComputador;
        private TabPage tabRegEmpresa;
        private TabPage tbReparar;
        private Label label2;
        private Label label1;
        private ComboBox cbMarca;
        private TextBox txtCapacidad;
        private TextBox txtTipoDisco;
        private TextBox txtSerial;
        private Label label4;
        private Label label3;
        private TextBox txtNitEmpresa;
        private Label label5;
        private TextBox txtNombreEmpresa;
        private Label label6;
        private Button btnRegComputador;
        private Button btnRegEmpresa;
    }
}