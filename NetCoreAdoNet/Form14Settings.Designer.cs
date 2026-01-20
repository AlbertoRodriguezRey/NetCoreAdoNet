namespace NetCoreAdoNet
{
    partial class Form14Settings
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
            BtnLeerSettings = new Button();
            lblConexion = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BtnLeerSettings
            // 
            BtnLeerSettings.Location = new Point(29, 27);
            BtnLeerSettings.Name = "BtnLeerSettings";
            BtnLeerSettings.Size = new Size(140, 42);
            BtnLeerSettings.TabIndex = 0;
            BtnLeerSettings.Text = "Leer Settings";
            BtnLeerSettings.UseVisualStyleBackColor = true;
            BtnLeerSettings.Click += BtnLeerSettings_Click;
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Location = new Point(29, 85);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(88, 20);
            lblConexion.TabIndex = 1;
            lblConexion.Text = "lblConexion";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(33, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(331, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(284, 298);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(331, 18);
            button1.Name = "button1";
            button1.Size = new Size(155, 51);
            button1.TabIndex = 4;
            button1.Text = "Leer Helper Configuration";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form14Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 435);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblConexion);
            Controls.Add(BtnLeerSettings);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form14Settings";
            Text = "Form14Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnLeerSettings;
        private Label lblConexion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
    }
}