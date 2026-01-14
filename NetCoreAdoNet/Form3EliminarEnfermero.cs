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
    public partial class Form3EliminarEnfermero : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form3EliminarEnfermero()
        {
            InitializeComponent();
            //CADENA DE CONEXION
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.LoadEnfermos();
        }

        private void LoadEnfermos()
        {
            string sql = "select * from ENFERMO";
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
            this.lstEnfermos.Items.Clear();
            while (this.reader.Read())
            {
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEnfermos.Items.Add(inscripcion + " - " + apellido);
            }
            //LIBERAMOS LOS RECURSOS
            this.reader.Close();
            this.cn.Close();
        }

        private void BtnEliminarEnfermo_Click(object sender, EventArgs e)
        {
            //NECESITAMOS EL DATO DE INSCRIPCION CONCATENADO
            //LOS PARAMETROS DEBEN SER DEL MISMO TIPO DE DATO QUE EN LA BASE DE DATOS EN ESTE CASO ES UN INT
            int inscripcion = int.Parse(this.textBox1.Text);
            //string inscripcion = this.textBox1.Text;
            string sql = "delete from ENFERMO where INSCRIPCION=@inscripcion";
            //DEBEMOS CONFIGURAR UNO O VARIOS PARAMETROS
            SqlParameter paramInscripcion = new SqlParameter("@inscripcion", inscripcion);
            //NOMBRE DEL PARAMETRO EN LA CONSULTA NO PUEDE ESTAR REPETIDO
            paramInscripcion.ParameterName = "@inscripcion";
            //TIPO DE DATO DEL PARAMETRO
            paramInscripcion.SqlDbType = SqlDbType.Int;
            //TAMBIEN PODEMOS USAR DbType
            //paramInscripcion.DbType = DbType.Int32;
            //POR DEFECTO LA DIRECCION ES INPUT
            paramInscripcion.Direction = ParameterDirection.Input;
            //EL VALOR DEL PARAMETRO PARA SUSTITUIR EN LA CONSULTA
            paramInscripcion.Value = inscripcion;
            //AGREGAMOS EL PARAMETRO A LA COLECCION DE PARAMETROS
            //EN ESTE CASO SOLO HAY UNO
            this.com.Parameters.Add(paramInscripcion);
            //CONFIGURAMOS LA CONSULTA
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            //LAS CONSULTAS DE ACCION DEVUELVEN UN int CON EL NUMERO DE
            //REGISTROS AFECTADOS
            //VA A DAR PROBLEMA SI QUEREMOS ELIMINAR MAS DE UN ENFERO PORQUE NO HEMOS LIMPIADO LA COLECCION DE PARAMETROS
            int registros = this.com.ExecuteNonQuery();
            this.cn.Close();
            //LIMPIAMOS LA COLECCION DE PARAMETROS PARA LA PROXIMA CONSULTA
            this.com.Parameters.Clear();
            this.LoadEnfermos();
            MessageBox.Show("Enfermos eliminados: " + registros);
        }
    }
}
