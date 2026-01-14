using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form7DepartamentosEmpleados : Form
    {
        RepositoryDepartamentosEmpleados repo;
        public Form7DepartamentosEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentosEmpleados();
            this.LoadDepartamentosAsync();
            this.lstDepartamentos.SelectedIndexChanged += new EventHandler(lstDepartamentos_SelectedIndexChanged);
        }

        public async void LoadDepartamentosAsync()
        {
            List<string> departamentos = await this.repo.GetNombresDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (string dept in departamentos)
            {
                this.lstDepartamentos.Items.Add(dept);
            }
        }

        public async void LoadEmpleadosDepartamentoAsync(string departamento)
        {
            List<string> empleados = await this.repo.GetEmpleadosDepartamentoAsync(departamento);
            this.lstEmpleados.Items.Clear();
            foreach (string emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp);
            }
        }

        public void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (this.lstDepartamentos.SelectedIndex != -1)
            {
                string departamento = this.lstDepartamentos.SelectedItem.ToString();
                this.LoadEmpleadosDepartamentoAsync(departamento);
            }
        }

        public async void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //LLAMAMOS AL METODO DeleteEmpleadoAsync CUANDO PULSAMOS EL BOTON
                if (this.lstEmpleados.SelectedItem != null)
                {
                    string apellido = this.lstEmpleados.SelectedItem.ToString();
                    int registros = await this.repo.DeleteEmpleadoAsync(apellido);
                    MessageBox.Show("Registros eliminados: " + registros);
                    //RECARGAMOS LA LISTA DE EMPLEADOS
                    string departamento = this.lstDepartamentos.SelectedItem.ToString();
                    this.LoadEmpleadosDepartamentoAsync(departamento);
                }
                else
                {
                    MessageBox.Show("Seleccione un empleado para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}");
            }

        }    
    }
}
