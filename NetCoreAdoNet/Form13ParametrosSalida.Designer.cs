namespace NetCoreAdoNet
{
    partial class Form13ParametrosSalida
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
            label1 = new Label();
            label2 = new Label();
            cmbDepartamentos = new ComboBox();
            BtnMostrarDatos = new Button();
            label3 = new Label();
            txtSuma = new TextBox();
            label4 = new Label();
            txtMedia = new TextBox();
            label5 = new Label();
            txtPersonas = new TextBox();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 18);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Empleados";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(23, 41);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(140, 28);
            cmbDepartamentos.TabIndex = 2;
            // 
            // BtnMostrarDatos
            // 
            BtnMostrarDatos.Location = new Point(23, 84);
            BtnMostrarDatos.Name = "BtnMostrarDatos";
            BtnMostrarDatos.Size = new Size(140, 54);
            BtnMostrarDatos.TabIndex = 3;
            BtnMostrarDatos.Text = "Mostrar datos";
            BtnMostrarDatos.UseVisualStyleBackColor = true;
            BtnMostrarDatos.Click += BtnMostrarDatos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 157);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 4;
            label3.Text = "Suma salarial";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(23, 180);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(140, 27);
            txtSuma.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 222);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 6;
            label4.Text = "Media salarial";
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(23, 245);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(140, 27);
            txtMedia.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 288);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 8;
            label5.Text = "Personas";
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(23, 311);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(140, 27);
            txtPersonas.TabIndex = 9;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(232, 41);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(189, 284);
            lstEmpleados.TabIndex = 10;
            // 
            // Form13ParametrosSalida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 365);
            Controls.Add(lstEmpleados);
            Controls.Add(txtPersonas);
            Controls.Add(label5);
            Controls.Add(txtMedia);
            Controls.Add(label4);
            Controls.Add(txtSuma);
            Controls.Add(label3);
            Controls.Add(BtnMostrarDatos);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form13ParametrosSalida";
            Text = "Form13ParametrosSalida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbDepartamentos;
        private Button BtnMostrarDatos;
        private Label label3;
        private TextBox txtSuma;
        private Label label4;
        private TextBox txtMedia;
        private Label label5;
        private TextBox txtPersonas;
        private ListBox lstEmpleados;
    }
}