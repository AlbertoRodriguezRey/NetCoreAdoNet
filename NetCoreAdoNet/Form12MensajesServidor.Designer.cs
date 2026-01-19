namespace NetCoreAdoNet
{
    partial class Form12MensajesServidor
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
            Id = new Label();
            Nombre = new Label();
            Localidad = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtLocalidad = new TextBox();
            BtnNuevoDepartamento = new Button();
            label4 = new Label();
            lblServidor = new Label();
            lstDepartamentos = new ListBox();
            SuspendLayout();
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(12, 31);
            Id.Name = "Id";
            Id.Size = new Size(22, 20);
            Id.TabIndex = 0;
            Id.Text = "Id";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(12, 101);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            // 
            // Localidad
            // 
            Localidad.AutoSize = true;
            Localidad.Location = new Point(12, 174);
            Localidad.Name = "Localidad";
            Localidad.Size = new Size(74, 20);
            Localidad.TabIndex = 2;
            Localidad.Text = "Localidad";
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 54);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(119, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(12, 197);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(119, 27);
            txtLocalidad.TabIndex = 5;
            // 
            // BtnNuevoDepartamento
            // 
            BtnNuevoDepartamento.Location = new Point(12, 243);
            BtnNuevoDepartamento.Name = "BtnNuevoDepartamento";
            BtnNuevoDepartamento.Size = new Size(119, 49);
            BtnNuevoDepartamento.TabIndex = 6;
            BtnNuevoDepartamento.Text = "Nuevo departamento";
            BtnNuevoDepartamento.UseVisualStyleBackColor = true;
            BtnNuevoDepartamento.Click += BtnNuevoDepartamento_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 31);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 7;
            label4.Text = "Departamentos";
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblServidor.ForeColor = Color.Blue;
            lblServidor.Location = new Point(12, 335);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(85, 20);
            lblServidor.TabIndex = 8;
            lblServidor.Text = "lblServidor";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(171, 54);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(374, 224);
            lstDepartamentos.TabIndex = 9;
            // 
            // Form12MensajesServidor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 364);
            Controls.Add(lstDepartamentos);
            Controls.Add(lblServidor);
            Controls.Add(label4);
            Controls.Add(BtnNuevoDepartamento);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(Localidad);
            Controls.Add(Nombre);
            Controls.Add(Id);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form12MensajesServidor";
            Text = "Form12MensajesServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Id;
        private Label Nombre;
        private Label Localidad;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtLocalidad;
        private Button BtnNuevoDepartamento;
        private Label label4;
        private Label lblServidor;
        private ListBox lstDepartamentos;
    }
}