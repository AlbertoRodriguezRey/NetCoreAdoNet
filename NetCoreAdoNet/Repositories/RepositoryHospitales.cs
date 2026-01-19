using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryHospitales
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryHospitales()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<Hospital>> GetHospitalesAsync() 
        {
            string sql = "select * from HOSPITAL";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Hospital> hospitales = new List<Hospital>();

            while (await this.reader.ReadAsync())
            {
                Hospital hospital = new Hospital();
                hospital.IdHospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hospital.Nombre = this.reader["NOMBRE"].ToString();
                hospital.Direccion = this.reader["DIRECCION"].ToString();
                hospital.Telefono = this.reader["TELEFONO"].ToString();
                hospital.Cama = int.Parse(this.reader["NUM_CAMA"].ToString());
                hospitales.Add(hospital);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return hospitales;
        }

        public async Task CreateHospitalAsync(int idHospital, string nombre, string direccion, string telefono, int cama) 
        {
            string sql = "insert into HOSPITAL values (@idHospital, @nombre, @direccion, @telefono, @cama)";
            SqlParameter pamId = new SqlParameter("@idHospital", idHospital);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamDireccion = new SqlParameter("@direccion", direccion);
            SqlParameter pamTelefono = new SqlParameter("@telefono", telefono);
            SqlParameter pamCama = new SqlParameter("@cama", cama);

            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamDireccion);
            this.com.Parameters.Add(pamTelefono);
            this.com.Parameters.Add(pamCama);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task UpdateHospitalAsync(int idHospital, string nombre, string direccion, string telefono, int cama) 
        {
            string sql = "update HOSPITAL set NOMBRE=@nombre, DIRECCION=@direccion, TELEFONO=@telefono, NUM_CAMA=@cama where HOSPITAL_COD=@idHospital";
            SqlParameter pamId = new SqlParameter("@idHospital", idHospital);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamDireccion = new SqlParameter("@direccion", direccion);
            SqlParameter pamTelefono = new SqlParameter("@telefono", telefono);
            SqlParameter pamCama = new SqlParameter("@cama", cama);
            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamDireccion);
            this.com.Parameters.Add(pamTelefono);
            this.com.Parameters.Add(pamCama);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task DeleteHospitalAsync(int idHospital) 
        {
            string sql = "delete from HOSPITAL where HOSPITAL_COD=@idHospital";
            SqlParameter pamId = new SqlParameter("@idHospital", idHospital);
            this.com.Parameters.Add(pamId);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
