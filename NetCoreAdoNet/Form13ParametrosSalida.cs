using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
//	select @suma = SUM(SALARIO), @media = AVG(SALARIO), @personas = COUNT(EMP_NO) from EMP
//	where DEPT_NO = @iddept
//go
#endregion

namespace NetCoreAdoNet
{
    public partial class Form13ParametrosSalida : Form
    {
        ReposityoParametersOut repo;
        public Form13ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new ReposityoParametersOut();
            this.LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            List<string> departamentos = await this.repo.GetDepartamentosAsync();
            this.cmbDepartamentos.Items.Clear();
            foreach (string dept in departamentos)
            {
                this.cmbDepartamentos.Items.Add(dept);
            }

        }

        private async void BtnMostrarDatos_Click(object sender, EventArgs e)
        {
            string departamento = this.cmbDepartamentos.SelectedItem.ToString();
            EmpleadosParametersOut model = await this.repo.GetEmpleadosDepartamentoOutAsync(departamento);
            this.lstEmpleados.Items.Clear();
            foreach (string apellido in model.Apellidos)
            {
                this.lstEmpleados.Items.Add(apellido);
            }
            this.txtSuma.Text = model.SumaSalarial.ToString();
            this.txtMedia.Text = model.MediaSalarial.ToString();
            this.txtPersonas.Text = model.Personas.ToString();

        }
    }
}
