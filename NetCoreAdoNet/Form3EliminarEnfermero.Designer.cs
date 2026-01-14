namespace NetCoreAdoNet
{
    partial class Form3EliminarEnfermero
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
            textBox1 = new TextBox();
            BtnEliminarEnfermo = new Button();
            label2 = new Label();
            lstEnfermos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Inscripcion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 27);
            textBox1.TabIndex = 1;
            // 
            // BtnEliminarEnfermo
            // 
            BtnEliminarEnfermo.Location = new Point(12, 101);
            BtnEliminarEnfermo.Name = "BtnEliminarEnfermo";
            BtnEliminarEnfermo.Size = new Size(131, 64);
            BtnEliminarEnfermo.TabIndex = 2;
            BtnEliminarEnfermo.Text = "Eliminar enfermo";
            BtnEliminarEnfermo.UseVisualStyleBackColor = true;
            BtnEliminarEnfermo.Click += BtnEliminarEnfermo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 27);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 3;
            label2.Text = "Enfermos";
            // 
            // lstEnfermos
            // 
            lstEnfermos.FormattingEnabled = true;
            lstEnfermos.Location = new Point(209, 50);
            lstEnfermos.Name = "lstEnfermos";
            lstEnfermos.Size = new Size(225, 244);
            lstEnfermos.TabIndex = 4;
            // 
            // Form3EliminarEnfermero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 358);
            Controls.Add(lstEnfermos);
            Controls.Add(label2);
            Controls.Add(BtnEliminarEnfermo);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3EliminarEnfermero";
            Text = "Form3EliminarEnfermero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button BtnEliminarEnfermo;
        private Label label2;
        private ListBox lstEnfermos;
    }
}