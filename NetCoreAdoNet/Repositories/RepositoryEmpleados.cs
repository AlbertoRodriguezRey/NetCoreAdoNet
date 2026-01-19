using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetOficiosAsync()
        {
            string sql = "select distinct OFICIO from EMP";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> oficiosList = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficiosList.Add(oficio);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return oficiosList;
        }

        public async Task<List<string>> GetEmpleadosByOficioAsync(string oficio)
        {
            string sql = "select APELLIDO from EMP where OFICIO = @oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> apellidos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                apellidos.Add(apellido);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return apellidos;
        }

        public async Task<int> UpdateSalarioEmpleadosAsync(string oficio, int incremento)
        {
            string sql = "update EMP set SALARIO = SALARIO + @incremento where OFICIO = @oficio";
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }

        public async Task<(int suma, int media, int maximo)> GetEstadisticasSalarioByOficioAsync(string oficio)
        {
            string sql = "select SUM(SALARIO) as SumaSalario, AVG(SALARIO) as MediaSalario, MAX(SALARIO) as MaximoSalario from EMP where OFICIO = @oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            int suma = 0;
            int media = 0;
            int maximo = 0;
            if (await this.reader.ReadAsync())
            {
                suma = Convert.ToInt32(this.reader["SumaSalario"]);
                media = Convert.ToInt32(this.reader["MediaSalario"]);
                maximo = Convert.ToInt32(this.reader["MaximoSalario"]);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return (suma, media, maximo);
        }

        public async Task<int> GetSalarioByApellidoAsync(string apellido)
        {
            string sql = "select SALARIO from EMP where APELLIDO = @apellido";
            this.com.Parameters.AddWithValue("@apellido", apellido);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            int salario = 0;
            if (await this.reader.ReadAsync())
            {
                salario = Convert.ToInt32(this.reader["SALARIO"]);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return salario;
        }
    }
}
