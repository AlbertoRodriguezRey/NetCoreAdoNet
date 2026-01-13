using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form1PrimerAdo : Form
    {
        //SOTA CABALLO Y REY
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        string connectionString;

        public Form1PrimerAdo()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection();
            this.com = new SqlCommand();
            this.cn.ConnectionString = this.connectionString;

        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                    this.lblConexion.BackColor = Color.LightGreen;
                    this.BtnConectar.Enabled = false;
                }
            }
            catch (SqlException ex) 
            {
                this.lblConexion.Text = "ERROR: " + ex.Message;
            }
        }

        private void BtnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblConexion.BackColor = Color.LightCoral;
            this.BtnConectar.Enabled = true;
        }
    }
}
