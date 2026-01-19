namespace NetCoreAdoNet
{
    partial class Form11ProcedimientosHospitalPlantilla
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
            cmbHospitales = new ComboBox();
            label2 = new Label();
            txtIncremento = new TextBox();
            BtnModificarSalario = new Button();
            label3 = new Label();
            lstPlantilla = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(25, 45);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(121, 28);
            cmbHospitales.TabIndex = 1;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 22);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 2;
            label2.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(194, 45);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(167, 27);
            txtIncremento.TabIndex = 3;
            // 
            // BtnModificarSalario
            // 
            BtnModificarSalario.Location = new Point(116, 96);
            BtnModificarSalario.Name = "BtnModificarSalario";
            BtnModificarSalario.Size = new Size(140, 30);
            BtnModificarSalario.TabIndex = 4;
            BtnModificarSalario.Text = "Modificar salarios";
            BtnModificarSalario.UseVisualStyleBackColor = true;
            BtnModificarSalario.Click += BtnModificarSalario_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 149);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(25, 172);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(336, 124);
            lstPlantilla.TabIndex = 6;
            // 
            // Form11ProcedimientosHospitalPlantilla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 332);
            Controls.Add(lstPlantilla);
            Controls.Add(label3);
            Controls.Add(BtnModificarSalario);
            Controls.Add(txtIncremento);
            Controls.Add(label2);
            Controls.Add(cmbHospitales);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form11ProcedimientosHospitalPlantilla";
            Text = "Form11ProcedimientosHospitalPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbHospitales;
        private Label label2;
        private TextBox txtIncremento;
        private Button BtnModificarSalario;
        private Label label3;
        private ListBox lstPlantilla;
    }
}