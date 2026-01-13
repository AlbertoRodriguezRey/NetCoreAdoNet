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
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.cn.StateChange += Cn_StateChange;

        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblConexion.Text = "La conexion esta pasando de " + e.OriginalState.ToString() + " a " + e.CurrentState.ToString();
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

        private void BtnRead_Click(object sender, EventArgs e)
        {
            string sql = "select * from EMP";
            //INDICAMOS LA CONEXION DEL COMMAND
            this.com.Connection = this.cn;
            //TIPO DE CONSULTA A REALIZAR
            this.com.CommandType = CommandType.Text;
            //INCLUIMOS LA CONSULTA EN EL COMMAND
            this.com.CommandText = sql;
            //AQUI DEBERIAMOS ABRIR LA CONEXION
            //EJECUTAR LA CONSULTA. COMO ES UN SELECT
            //UTILIZAMOS ExecuteReader() QUE NOS DEVUELVE UN DataReader
            this.reader = this.com.ExecuteReader();
            //PARA LA ESTRUCTURA DE LA TABLA SE UTILIZAR FOR
            for (int i = 0; i < this.reader.FieldCount; i++)
            {
                //LEEMOS LA PRIMERA COLUMNA DE LA CONSULTA
                string columna = this.reader.GetName(i);
                //LEEMOS TAMBIEN EL TIPO DE DATO DE LA PRIMERA COLUMNA
                string tipo = this.reader.GetDataTypeName(i);
                this.lstColumnas.Items.Add(columna);
                this.lstTipos.Items.Add(tipo);
            }
            //DEBEMOS INDICAR EL METODO read() PARA LEER LOS REGISTROS
            while (this.reader.Read())
            {
                //LEEMOS EL PIRMER REGISTRO (APELLIDO)
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
                //SIEMPRE DEBEMOS SALIR; CERRAR
                
            }
            this.reader.Close();
        }
    }
}
