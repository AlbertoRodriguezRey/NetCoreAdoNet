namespace NetCoreAdoNet
{
    partial class Form5UpdateSalas
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
            BtnUpdate = new Button();
            lstSalas = new ListBox();
            label1 = new Label();
            txtNuevoNombre = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(290, 102);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(118, 40);
            BtnUpdate.TabIndex = 0;
            BtnUpdate.Text = "Actualizar";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(27, 69);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(204, 244);
            lstSalas.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 31);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 2;
            label1.Text = "Salas";
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Location = new Point(290, 69);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(118, 27);
            txtNuevoNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 31);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 4;
            label2.Text = "Selecciona una sala";
            // 
            // Form5UpdateSalas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 467);
            Controls.Add(label2);
            Controls.Add(txtNuevoNombre);
            Controls.Add(label1);
            Controls.Add(lstSalas);
            Controls.Add(BtnUpdate);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form5UpdateSalas";
            Text = "Form5UpdateSalas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnUpdate;
        private ListBox lstSalas;
        private Label label1;
        private TextBox txtNuevoNombre;
        private Label label2;
    }
}