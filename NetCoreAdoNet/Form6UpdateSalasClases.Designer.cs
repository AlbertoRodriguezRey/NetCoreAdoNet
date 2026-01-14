namespace NetCoreAdoNet
{
    partial class Form6UpdateSalasClases
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
            label2 = new Label();
            txtNuevoNombre = new TextBox();
            label1 = new Label();
            lstSalas = new ListBox();
            BtnUpdate = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 36);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 9;
            label2.Text = "Selecciona una sala";
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Location = new Point(300, 74);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(118, 27);
            txtNuevoNombre.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 36);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 7;
            label1.Text = "Salas";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(37, 74);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(204, 244);
            lstSalas.TabIndex = 6;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(300, 107);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(118, 40);
            BtnUpdate.TabIndex = 5;
            BtnUpdate.Text = "Actualizar";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // Form6UpdateSalasClases
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(475, 505);
            Controls.Add(label2);
            Controls.Add(txtNuevoNombre);
            Controls.Add(label1);
            Controls.Add(lstSalas);
            Controls.Add(BtnUpdate);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form6UpdateSalasClases";
            Text = "Form6UpdateSalasClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtNuevoNombre;
        private Label label1;
        private ListBox lstSalas;
        private Button BtnUpdate;
    }
}