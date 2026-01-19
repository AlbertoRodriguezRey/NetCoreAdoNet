using NetCoreAdoNet.Models;
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
    public partial class Form9CrudHospital : Form
    {
        RepositoryHospitales repo;
        public Form9CrudHospital()
        {
            InitializeComponent();
            this.repo = new RepositoryHospitales();
            this.LoadHospitales();
        }

        public async Task LoadHospitales()
        {
            List<Hospital> hospitales = await this.repo.GetHospitalesAsync();
            this.lstHospitales.Items.Clear();
            foreach (Hospital hospital in hospitales)
            {
                this.lstHospitales.Items.Add(hospital.IdHospital + " - " + hospital.Nombre + " - " + hospital.Direccion + " - " + hospital.Telefono + " - " + hospital.Cama);
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            await this.repo.DeleteHospitalAsync(id);
            await this.LoadHospitales();
        }

        private async void BtnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int cama = int.Parse(this.txtCama.Text);
            await this.repo.CreateHospitalAsync(id, nombre, direccion, telefono, cama);
            await this.LoadHospitales();
        }

        private async void BtnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int cama = int.Parse(this.txtCama.Text);
            await this.repo.UpdateHospitalAsync(id, nombre, direccion, telefono, cama);
            await this.LoadHospitales();
        }
    }
}
