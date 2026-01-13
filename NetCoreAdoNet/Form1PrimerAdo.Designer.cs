namespace NetCoreAdoNet
{
    partial class Form1PrimerAdo
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
            BtnConectar = new Button();
            BtnDesconectar = new Button();
            BtnRead = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstApellidos = new ListBox();
            lstColumnas = new ListBox();
            lstTipos = new ListBox();
            lblConexion = new Label();
            SuspendLayout();
            // 
            // BtnConectar
            // 
            BtnConectar.Location = new Point(12, 59);
            BtnConectar.Name = "BtnConectar";
            BtnConectar.Size = new Size(107, 40);
            BtnConectar.TabIndex = 0;
            BtnConectar.Text = "Conectar";
            BtnConectar.UseVisualStyleBackColor = true;
            BtnConectar.Click += BtnConectar_Click;
            // 
            // BtnDesconectar
            // 
            BtnDesconectar.Location = new Point(12, 125);
            BtnDesconectar.Name = "BtnDesconectar";
            BtnDesconectar.Size = new Size(107, 40);
            BtnDesconectar.TabIndex = 1;
            BtnDesconectar.Text = "Desconectar";
            BtnDesconectar.UseVisualStyleBackColor = true;
            BtnDesconectar.Click += BtnDesconectar_Click;
            // 
            // BtnRead
            // 
            BtnRead.Location = new Point(12, 180);
            BtnRead.Name = "BtnRead";
            BtnRead.Size = new Size(107, 56);
            BtnRead.TabIndex = 2;
            BtnRead.Text = "Read";
            BtnRead.UseVisualStyleBackColor = true;
            BtnRead.Click += BtnRead_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 3;
            label1.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 9);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 4;
            label2.Text = "Columnas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 9);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 5;
            label3.Text = "Tipos dato";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(125, 32);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(120, 304);
            lstApellidos.TabIndex = 6;
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(265, 32);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(120, 304);
            lstColumnas.TabIndex = 7;
            // 
            // lstTipos
            // 
            lstTipos.FormattingEnabled = true;
            lstTipos.Location = new Point(408, 32);
            lstTipos.Name = "lstTipos";
            lstTipos.Size = new Size(120, 304);
            lstTipos.TabIndex = 8;
            // 
            // lblConexion
            // 
            lblConexion.Location = new Point(12, 239);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(107, 97);
            lblConexion.TabIndex = 9;
            lblConexion.Text = "lblConexion";
            // 
            // Form1PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 359);
            Controls.Add(lblConexion);
            Controls.Add(lstTipos);
            Controls.Add(lstColumnas);
            Controls.Add(lstApellidos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnRead);
            Controls.Add(BtnDesconectar);
            Controls.Add(BtnConectar);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1PrimerAdo";
            Text = "Form1PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnConectar;
        private Button BtnDesconectar;
        private Button BtnRead;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstApellidos;
        private ListBox lstColumnas;
        private ListBox lstTipos;
        private Label lblConexion;
    }
}