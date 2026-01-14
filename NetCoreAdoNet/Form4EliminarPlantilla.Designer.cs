namespace NetCoreAdoNet
{
    partial class Form4EliminarPlantilla
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
            txtEmpleado = new TextBox();
            BtnEliminarPlantilla = new Button();
            label2 = new Label();
            lstPlantilla = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Empleado";
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(14, 53);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(123, 27);
            txtEmpleado.TabIndex = 1;
            // 
            // BtnEliminarPlantilla
            // 
            BtnEliminarPlantilla.Location = new Point(14, 104);
            BtnEliminarPlantilla.Name = "BtnEliminarPlantilla";
            BtnEliminarPlantilla.Size = new Size(123, 64);
            BtnEliminarPlantilla.TabIndex = 2;
            BtnEliminarPlantilla.Text = "Eliminar plantilla";
            BtnEliminarPlantilla.UseVisualStyleBackColor = true;
            BtnEliminarPlantilla.Click += BtnEliminarPlantilla_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 19);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(181, 53);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(241, 264);
            lstPlantilla.TabIndex = 4;
            // 
            // Form4EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 425);
            Controls.Add(lstPlantilla);
            Controls.Add(label2);
            Controls.Add(BtnEliminarPlantilla);
            Controls.Add(txtEmpleado);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form4EliminarPlantilla";
            Text = "Form4EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmpleado;
        private Button BtnEliminarPlantilla;
        private Label label2;
        private ListBox lstPlantilla;
    }
}