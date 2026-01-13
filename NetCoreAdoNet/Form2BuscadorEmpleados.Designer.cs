namespace NetCoreAdoNet
{
    partial class Form2BuscadorEmpleados
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
            txtSalario = new TextBox();
            BtnBuscarEmpleados = new Button();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 23);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 0;
            label1.Text = "Buscador Empleados";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(47, 55);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(268, 27);
            txtSalario.TabIndex = 1;
            // 
            // BtnBuscarEmpleados
            // 
            BtnBuscarEmpleados.Location = new Point(110, 88);
            BtnBuscarEmpleados.Name = "BtnBuscarEmpleados";
            BtnBuscarEmpleados.Size = new Size(148, 33);
            BtnBuscarEmpleados.TabIndex = 2;
            BtnBuscarEmpleados.Text = "Buscar Empleados";
            BtnBuscarEmpleados.UseVisualStyleBackColor = true;
            BtnBuscarEmpleados.Click += BtnBuscarEmpleados_Click;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(47, 138);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(268, 324);
            lstEmpleados.TabIndex = 3;
            // 
            // Form2BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 484);
            Controls.Add(lstEmpleados);
            Controls.Add(BtnBuscarEmpleados);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2BuscadorEmpleados";
            Text = "Form2BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSalario;
        private Button BtnBuscarEmpleados;
        private ListBox lstEmpleados;
    }
}