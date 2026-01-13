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
    public partial class Form2BuscadorEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form2BuscadorEmpleados()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        private void BtnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            //VAMOS A CONCATENAR POR LO QUE NUESTRO SALARIO SERA UN STRING
            string salario = this.txtSalario.Text;
            //CONSULTA SQL
            string sql = "select * from EMP where SALARIO >= " + salario;
            //CONFIGURAMOS EL COMANDO
            //CONNECTION
            this.com.Connection = this.cn;
            //TIPO DE CONSULTA
            this.com.CommandType = CommandType.Text;
            //LA CONSULTA
            this.com.CommandText = sql;
            //ENTRAR Y SALIR
            //ABRIMOS LA CONEXION
            this.cn.Open();
            //EJECUTAMOS LA CONSULTA
            this.reader = this.com.ExecuteReader();
            //LEEMOS LOS DATOS
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                //LEEMOS LOS CAMPOS QUE NOS INTERESAN
                string apellido = this.reader["APELLIDO"].ToString();
                string salarioEmpleado = this.reader["SALARIO"].ToString();
                //MOSTRAMOS EL RESULTADO
                this.lstEmpleados.Items.Add(apellido + " - " + salarioEmpleado);
            }
            //SALIMOS, LIBERAMOS RECURSOS
            this.reader.Close();
            this.cn.Close();
        }
    }
}
