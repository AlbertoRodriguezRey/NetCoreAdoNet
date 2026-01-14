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
    public partial class Form6UpdateSalasClases : Form
    {
        RepositorySalas repo;
        public Form6UpdateSalasClases()
        {
            InitializeComponent();
            this.repo = new RepositorySalas();
            this.loadSalas();
        }

        private void loadSalas() 
        { 
            List<string> salas = this.repo.GetNombresSalas();
            this.lstSalas.Items.Clear();
            foreach (string sala in salas) 
            {
                this.lstSalas.Items.Add(sala);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string oldName = this.lstSalas.SelectedItem.ToString();
            string newName = this.txtNuevoNombre.Text;
            int registros = this.repo.UpdateSala(newName, oldName);
            MessageBox.Show("Registros afectados: " + registros);
            this.loadSalas();
        }
    }
}
