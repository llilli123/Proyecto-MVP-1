using Proyecto_MVP_1.Views.Interfaces;
using Proyecto_MVP_1.Views; // Para poder llamar a 'ClientesView', etc.
using System;

namespace Proyecto_MVP_1.Presenters
{
    public class DashboardPresenter
    {
        private readonly IDashboardView _view;

        // --- ELIMINAMOS EL REPOSITORIO ---
        // El constructor ahora solo recibe la vista
        public DashboardPresenter(IDashboardView view)
        {
            _view = view;

            // Conectamos SOLO los clics de los botones
            _view.NavigateToClientes += OnNavigateToClientes;
            _view.NavigateToEquipos += OnNavigateToEquipos;
            _view.NavigateToAlquileres += OnNavigateToAlquileres;
            _view.Logout += OnLogout;
        }

        // --- ELIMINAMOS 'OnDashboardLoad' ---

        // --- Lógica de Navegación ---
        private void OnNavigateToClientes(object sender, EventArgs e)
        {
            var clientesView = new ClientesView();
            // new ClientesPresenter(clientesView, ...); // Si Clientes usa MVP
            clientesView.Show();
            _view.Hide();
        }

        private void OnNavigateToEquipos(object sender, EventArgs e)
        {
            var equiposView = new EquiposView();
            // new EquiposPresenter(equiposView, ...);
            equiposView.Show();
            _view.Hide();
        }

        private void OnNavigateToAlquileres(object sender, EventArgs e)
        {
            var alquileresView = new AlquileresView();
            // new AlquileresPresenter(alquileresView, ...);
            alquileresView.Show();
            _view.Hide();
        }

        private void OnLogout(object sender, EventArgs e)
        {
            // Lógica para volver al Login
            // var loginView = new LoginView();
            // loginView.Show();
            _view.Close();
        }
    }
}