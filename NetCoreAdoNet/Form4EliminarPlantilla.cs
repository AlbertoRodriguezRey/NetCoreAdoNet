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
    public partial class Form4EliminarPlantilla : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form4EliminarPlantilla()
        {
            InitializeComponent();
            //CADENA DE CONEXION
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.loadPlantillas();
        }

        private void loadPlantillas()
        {
            string sql = "select * from PLANTILLA";
            //CONFIGURAMOS CONEXION
            this.com.Connection = this.cn;
            //TIPO DE CONSULTA
            this.com.CommandType = CommandType.Text;
            //LA CONSULTA
            this.com.CommandText = sql;
            //ABRIMOS LA CONEXION
            this.cn.Open();
            //EJECUTAMOS LA CONSULTA
            this.reader = this.com.ExecuteReader();
            this.lstPlantilla.Items.Clear();
            while (this.reader.Read())
            {
                string idEmpleado = this.reader["EMPLEADO_NO"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                string funcion = this.reader["FUNCION"].ToString();
                this.lstPlantilla.Items.Add(idEmpleado + " - " + apellido + " - " + funcion);
            }
            //LIBERAMOS LOS RECURSOS
            this.reader.Close();
            this.cn.Close();
        }

        private void BtnEliminarPlantilla_Click(object sender, EventArgs e)
        {
            //NECESITAMOS EL DATO DE EMPLEADO_NO CONCATENADO
            string idEmpleado = this.txtEmpleado.Text;
            string sql = "delete from PLANTILLA where EMPLEADO_NO=" + idEmpleado;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            //ABRIMOS LA CONEXION
            this.cn.Open();
            //LAS CONSULTAS DE ACCION DEVUELVEN UN int CON EL NUMERO DE
            //REGISTROS AFECTADOS
            int afectados = this.com.ExecuteNonQuery();
            //LIBERAMOS LOS RECURSOS
            this.cn.Close();
            //RECARGAMOS LA LISTA
            this.loadPlantillas();
            MessageBox.Show(afectados + " registros eliminados");
        }
    }
}
