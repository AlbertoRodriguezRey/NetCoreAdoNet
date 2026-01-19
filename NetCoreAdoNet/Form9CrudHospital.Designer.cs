namespace NetCoreAdoNet
{
    partial class Form9CrudHospital
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
            lstHospitales = new ListBox();
            label2 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtDireccion = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            txtCama = new TextBox();
            BtnEliminar = new Button();
            BtnInsertar = new Button();
            BtnModificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.Location = new Point(30, 63);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(419, 244);
            lstHospitales.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 27);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 2;
            label2.Text = "Id Hospital";
            // 
            // txtId
            // 
            txtId.Location = new Point(487, 63);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 93);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(487, 116);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 27);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(487, 146);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 6;
            label4.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(487, 169);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 27);
            txtDireccion.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(487, 199);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 8;
            label5.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(487, 222);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 27);
            txtTelefono.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 252);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 10;
            label6.Text = "Camas";
            // 
            // txtCama
            // 
            txtCama.Location = new Point(487, 275);
            txtCama.Name = "txtCama";
            txtCama.Size = new Size(100, 27);
            txtCama.TabIndex = 11;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(12, 350);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(100, 30);
            BtnEliminar.TabIndex = 12;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnInsertar
            // 
            BtnInsertar.Location = new Point(118, 350);
            BtnInsertar.Name = "BtnInsertar";
            BtnInsertar.Size = new Size(100, 30);
            BtnInsertar.TabIndex = 13;
            BtnInsertar.Text = "Insertar";
            BtnInsertar.UseVisualStyleBackColor = true;
            BtnInsertar.Click += BtnInsertar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(224, 350);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(100, 30);
            BtnModificar.TabIndex = 14;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // Form9CrudHospital
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 413);
            Controls.Add(BtnModificar);
            Controls.Add(BtnInsertar);
            Controls.Add(BtnEliminar);
            Controls.Add(txtCama);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form9CrudHospital";
            Text = "Form9CrudHospital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstHospitales;
        private Label label2;
        private TextBox txtId;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtDireccion;
        private Label label5;
        private TextBox txtTelefono;
        private Label label6;
        private TextBox txtCama;
        private Button BtnEliminar;
        private Button BtnInsertar;
        private Button BtnModificar;
    }
}