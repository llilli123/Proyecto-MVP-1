using Proyecto_MVP_1.Views.Interfaces;
using System;
using System.Windows.Forms;

namespace Proyecto_MVP_1.Views
{
    public partial class DashboardView : Form, IDashboardView
    {
        public DashboardView()
        {
            InitializeComponent();
            // YA NO NECESITAMOS EL EVENTO 'Load'
        }

        // --- ELIMINAMOS LAS PROPIEDADES "set" ---
        // (Las líneas 'public string StatEquiposDisponibles...')

        // --- Implementación de Eventos ---
        // (Quitamos 'DashboardLoad')
        public event EventHandler NavigateToClientes;
        public event EventHandler NavigateToEquipos;
        public event EventHandler NavigateToAlquileres;
        public event EventHandler Logout;

        // --- Disparadores de Eventos ---
        // (Quitamos 'DashboardView_Load')

        private void buttonNavClientes_Click_1(object sender, EventArgs e)
        {
            NavigateToClientes?.Invoke(this, EventArgs.Empty);
        }

        private void buttonNavEquipos_Click_1(object sender, EventArgs e)
        {
            NavigateToEquipos?.Invoke(this, EventArgs.Empty);
        }

        private void buttonNavAlquileres_Click_1(object sender, EventArgs e)
        {
            NavigateToAlquileres?.Invoke(this, EventArgs.Empty);
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            Logout?.Invoke(this, EventArgs.Empty);
        }
    }
}