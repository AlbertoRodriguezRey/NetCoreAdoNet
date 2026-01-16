namespace NetCoreAdoNet
{
    partial class Form8CrudDepartamentos
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
            lstDepartamentos = new ListBox();
            label2 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtLocalidad = new TextBox();
            BtnInsertar = new Button();
            BtnModificar = new Button();
            BtnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 33);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(42, 66);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(283, 244);
            lstDepartamentos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 33);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 2;
            label2.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(393, 66);
            txtId.Name = "txtId";
            txtId.Size = new Size(172, 27);
            txtId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 117);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(393, 150);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(172, 27);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 202);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 6;
            label4.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(393, 236);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(172, 27);
            txtLocalidad.TabIndex = 7;
            // 
            // BtnInsertar
            // 
            BtnInsertar.Location = new Point(393, 304);
            BtnInsertar.Name = "BtnInsertar";
            BtnInsertar.Size = new Size(172, 31);
            BtnInsertar.TabIndex = 8;
            BtnInsertar.Text = "Insertar";
            BtnInsertar.UseVisualStyleBackColor = true;
            BtnInsertar.Click += BtnInsertar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(393, 347);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(172, 30);
            BtnModificar.TabIndex = 9;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(42, 337);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(145, 40);
            BtnEliminar.TabIndex = 10;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // Form8CrudDepartamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 399);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnModificar);
            Controls.Add(BtnInsertar);
            Controls.Add(txtLocalidad);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(lstDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form8CrudDepartamentos";
            Text = "Form8CrudDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDepartamentos;
        private Label label2;
        private TextBox txtId;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtLocalidad;
        private Button BtnInsertar;
        private Button BtnModificar;
        private Button BtnEliminar;
    }
}