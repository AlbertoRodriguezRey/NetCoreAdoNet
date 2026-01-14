using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace NetCoreAdoNet.Repositories
{
    public class RepositorySalas
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositorySalas() 
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<string> GetNombresSalas()
        { 
            string sql = "select distinct NOMBRE from SALA";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            //CREAMOS LA COLECCION A DEVOLVER
            List<string> salas = new List<string>();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                salas.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
            return salas;
        }

        public int UpdateSala(string newName, string Oldname)
        {
            string sql = "update SALA set NOMBRE=@newname where NOMBRE=@oldname";
            SqlParameter pamNewName = new SqlParameter("@newname", newName);
            SqlParameter pamOldName = new SqlParameter("@oldname", Oldname);
            this.com.Parameters.Add(pamNewName);
            this.com.Parameters.Add(pamOldName);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int registros = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return registros;
        }
    }
}
