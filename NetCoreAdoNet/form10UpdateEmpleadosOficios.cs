using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class form10UpdateEmpleadosOficios : Form
    {
        RepositoryEmpleados repo;
        public form10UpdateEmpleadosOficios()
        {
            InitializeComponent();
            this.repo = new RepositoryEmpleados();
        }

        private async void form10UpdateEmpleadosOficios_Load(object sender, EventArgs e)
        {
            await this.LoadOficios();
        }

        public async Task LoadOficios()
        {
            List<string> oficios = await this.repo.GetOficiosAsync();
            this.lstOficios.Items.Clear();
            foreach (string oficio in oficios)
            {
                this.lstOficios.Items.Add(oficio);
            }
        }

        private async void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstOficios.SelectedIndex;
            if (index != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();

                // 1. Cargamos la lista de empleados
                List<string> empleados = await this.repo.GetEmpleadosByOficioAsync(oficio);
                this.lstEmpleados.Items.Clear();
                foreach (string empleado in empleados)
                {
                    this.lstEmpleados.Items.Add(empleado);
                }

                // 2. Cargamos las estadisticas salariales
                (int suma, int media, int maximo) = await this.repo.GetEstadisticasSalarioByOficioAsync(oficio);

                this.lblSumaSalarial.Text = "Suma: " + suma.ToString();
                this.lblMediaSalarial.Text = "Media: " + media.ToString();
                this.lblMaximoSalario.Text = "Máximo: " + maximo.ToString();

                // Limpiamos el salario individual anterior para no confundir
                this.lblSalario.Text = "Salario individual...";
            }
        }

        private async void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstEmpleados.SelectedIndex;
            if (index != -1)
            {
                string apellido = this.lstEmpleados.SelectedItem.ToString();
                decimal salario = await this.repo.GetSalarioByApellidoAsync(apellido);
                this.lblSalario.Text = "Salario: " + salario.ToString("C");
            }
        }



        private async void BtnSubirSalario_Click(object sender, EventArgs e)
        {
            // 1. Validaciones previas
            if (this.lstOficios.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un oficio primero");
                return;
            }

            // Validar que el incremento es numérico
            int incremento = 0;
            if (!int.TryParse(this.txtIncremento.Text, out incremento))
            {
                MessageBox.Show("Debes escribir una cantidad numérica válida");
                return;
            }

            // 2. Ejecutar la actualizacion
            string oficio = this.lstOficios.SelectedItem.ToString();

            // Llamamos al metodo asincrono
            int modificados = await this.repo.UpdateSalarioEmpleadosAsync(oficio, incremento);

            MessageBox.Show($"Se han actualizado {modificados} empleados del oficio {oficio}");

            // 3. Refrescar la informacion mostrada
            (int suma, int media, int maximo) = await this.repo.GetEstadisticasSalarioByOficioAsync(oficio);
            this.lblSumaSalarial.Text = "Suma: " + suma.ToString();
            this.lblMediaSalarial.Text = "Media: " + media.ToString();
            this.lblMaximoSalario.Text = "Máximo: " + maximo.ToString();

            // Refrescar el salario individual si hay un empleado seleccionado
            if (this.lstEmpleados.SelectedIndex != -1)
            {
                string apellido = this.lstEmpleados.SelectedItem.ToString();
                int salarioActual = await this.repo.GetSalarioByApellidoAsync(apellido);
                this.lblSalario.Text = "Salario: " + salarioActual.ToString();
            }
        }
    }
}
