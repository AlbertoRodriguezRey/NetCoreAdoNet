namespace NetCoreAdoNet
{
    partial class form10UpdateEmpleadosOficios
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
            lstOficios = new ListBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            label3 = new Label();
            txtIncremento = new TextBox();
            BtnSubirSalario = new Button();
            lblSumaSalarial = new Label();
            lblMediaSalarial = new Label();
            lblMaximoSalario = new Label();
            lblSalario = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 47);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(34, 71);
            lstOficios.Margin = new Padding(3, 4, 3, 4);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(161, 264);
            lstOficios.TabIndex = 1;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 47);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(214, 71);
            lstEmpleados.Margin = new Padding(3, 4, 3, 4);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(162, 264);
            lstEmpleados.TabIndex = 3;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 47);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 4;
            label3.Text = "Incremento salarial";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(432, 71);
            txtIncremento.Margin = new Padding(3, 4, 3, 4);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(135, 27);
            txtIncremento.TabIndex = 5;
            // 
            // BtnSubirSalario
            // 
            BtnSubirSalario.Location = new Point(432, 106);
            BtnSubirSalario.Margin = new Padding(3, 4, 3, 4);
            BtnSubirSalario.Name = "BtnSubirSalario";
            BtnSubirSalario.Size = new Size(135, 31);
            BtnSubirSalario.TabIndex = 6;
            BtnSubirSalario.Text = "Subir salarios";
            BtnSubirSalario.UseVisualStyleBackColor = true;
            BtnSubirSalario.Click += BtnSubirSalario_Click;
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(34, 350);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(112, 20);
            lblSumaSalarial.TabIndex = 7;
            lblSumaSalarial.Text = "lblSumaSalarial";
            // 
            // lblMediaSalarial
            // 
            lblMediaSalarial.AutoSize = true;
            lblMediaSalarial.Location = new Point(34, 370);
            lblMediaSalarial.Name = "lblMediaSalarial";
            lblMediaSalarial.Size = new Size(117, 20);
            lblMediaSalarial.TabIndex = 8;
            lblMediaSalarial.Text = "lblMediaSalarial";
            // 
            // lblMaximoSalario
            // 
            lblMaximoSalario.AutoSize = true;
            lblMaximoSalario.Location = new Point(34, 390);
            lblMaximoSalario.Name = "lblMaximoSalario";
            lblMaximoSalario.Size = new Size(126, 20);
            lblMaximoSalario.TabIndex = 9;
            lblMaximoSalario.Text = "lblMaximoSalario";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(214, 350);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(72, 20);
            lblSalario.TabIndex = 10;
            lblSalario.Text = "lblSalario";
            // 
            // form10UpdateEmpleadosOficios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 431);
            Controls.Add(lblSalario);
            Controls.Add(lblMaximoSalario);
            Controls.Add(lblMediaSalarial);
            Controls.Add(lblSumaSalarial);
            Controls.Add(BtnSubirSalario);
            Controls.Add(txtIncremento);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(lstOficios);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "form10UpdateEmpleadosOficios";
            Text = "form9UpdateEmpleadosOficios";
            Load += form10UpdateEmpleadosOficios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstOficios;
        private Label label2;
        private ListBox lstEmpleados;
        private Label label3;
        private TextBox txtIncremento;
        private Button BtnSubirSalario;
        private Label lblSumaSalarial;
        private Label lblMediaSalarial;
        private Label lblMaximoSalario;
        private Label lblSalario;
    }
}