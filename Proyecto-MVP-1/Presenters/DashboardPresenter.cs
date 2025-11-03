using Proyecto_MVP_1.Views; // Para poder llamar a 'ClientesView', etc.
using Proyecto_MVP_1.Views.Interfaces;
using System;
using System.Windows.Forms;

namespace Proyecto_MVP_1.Presenters
{
    public class DashboardPresenter
    {
        private readonly IDashboardView _view;
        private readonly Form _dashboardForm;

        // --- ELIMINAMOS EL REPOSITORIO ---
        // El constructor ahora solo recibe la vista
        public DashboardPresenter(IDashboardView view)
        {
            _view = view;
            _dashboardForm = (Form)view;

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
            var v = new ClientesView();
            // Si hay MVP: new ClientesPresenter(v, ...);

            // ① cuando se cierre el hijo, vuelve a mostrar el MISMO dashboard
            v.FormClosed += (_, __) => _dashboardForm.Show();

            // ② asigna dueño para evitar “huérfanos”
            v.Show(_dashboardForm);      // <-- IMPORTANTÍSIMO: Owner = dashboard

            // ③ oculta el dashboard (NO lo cierres)
            _dashboardForm.Hide();
        }

        private void OnNavigateToEquipos(object sender, EventArgs e)
        {
            var v = new EquiposView();
            v.FormClosed += (_, __) => _dashboardForm.Show();
            v.Show(_dashboardForm);
            _dashboardForm.Hide();
        }

        private void OnNavigateToAlquileres(object sender, EventArgs e)
        {
            var v = new AlquileresView();
            v.FormClosed += (_, __) => _dashboardForm.Show();
            v.Show(_dashboardForm);
            _dashboardForm.Hide();
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