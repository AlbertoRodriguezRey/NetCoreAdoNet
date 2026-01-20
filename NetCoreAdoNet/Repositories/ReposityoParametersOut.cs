using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
#region PROCEDIMIENTOS ALMACENADOS
//create procedure SP_ALL_DEPARTAMENTOS
//as
//	select * from DEPT
//go
//create procedure SP_EMPLEADOS_DEPARTAMENTOS_OUT
//(@nombre nvarchar(50), @suma int OUT, @media int OUT, @personas int OUT)
//as
//	declare @iddept int
//	select @iddept = DEPT_NO from DEPT
//	where DNOMBRE = @nombre
//	--LA CONSULTA DEL PROCEDIMIENTO
//	select * from EMP where DEPT_NO = @iddept
//	--RELLENAMOS LAS VARAIBLE SDE SALIDA
//	select @suma = isnull(SUM(SALARIO), 0),
//    @media = isnull(AVG(SALARIO), 0),
//    @personas = COUNT(EMP_NO) from EMP
//	where DEPT_NO = @iddept
//go
#endregion

namespace NetCoreAdoNet.Repositories
{
    public class ReposityoParametersOut
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public ReposityoParametersOut()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;

        }

        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> departamentos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                departamentos.Add(nombre);
            }
            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
            return departamentos;
        }

        public async Task<EmpleadosParametersOut> GetEmpleadosDepartamentoOutAsync(string nombreDepartamento)
        {
            string sql = "SP_EMPLEADOS_DEPARTAMENTOS_OUT";
            //TENEMOS UN PARAMETRO DE ENTRADA, POR DEFECTO, TODOS SON DE ENTRADA
            //PERFECTAMENTE PODEMOS SEGUIR UTILIZANDO AddWithValue
            //CON DICHO PARAMETRO
            //string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            //this.com.Parameters.AddWithValue("@nombre", nombre);
            string nombre = nombreDepartamento;
            SqlParameter paramNombre = new SqlParameter();
            paramNombre.ParameterName = "@nombre";
            paramNombre.Value = nombre;
            this.com.Parameters.Add(paramNombre);
            //LOS PARAMETROS DE SALIDA DEBEMOS CREARLOS DE FORMA EXPLICITA
            //POR EJEMPLO, NO HEMOS PUESTO VALORES POR DEFECTO A LOS PARAMETROS
            //POR LO QUE SON OBLIGATORIOS
            SqlParameter paramSuma = new SqlParameter();
            paramSuma.ParameterName = "@suma";
            paramSuma.Value = 0;
            paramSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramSuma);
            SqlParameter paramMedia = new SqlParameter();
            paramMedia.ParameterName = "@media";
            paramMedia.Value = 0;
            paramMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramMedia);
            SqlParameter paramPersonas = new SqlParameter();
            paramPersonas.ParameterName = "@personas";
            paramPersonas.Value = 0;
            paramPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramPersonas);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            EmpleadosParametersOut model = new EmpleadosParametersOut();
            //model.Apellidos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                model.Apellidos.Add(apellido);
            }
            await this.reader.CloseAsync();
            //DIBUJAMOS LOS PARAMETROS
            model.SumaSalarial = int.Parse(paramSuma.Value.ToString());
            model.MediaSalarial = int.Parse(paramMedia.Value.ToString());
            model.Personas = int.Parse(paramPersonas.Value.ToString());
            //LIBERAMOS RECURSOS
            await this.cn.CloseAsync();
            //LIMPIAMOS LOS PARAMETROS
            this.com.Parameters.Clear();
            return model;
        }

    }
}
