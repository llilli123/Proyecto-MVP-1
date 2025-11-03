using Proyecto_MVP_1.Models;
using Proyecto_MVP_1.Models.Entities;
using Proyecto_MVP_1.Presenters;
using Proyecto_MVP_1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLoginMVP.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly RentalPrimeDBEntities _context;

        public LoginPresenter(ILoginView view)
        {
            _view = view;
            _context = new RentalPrimeDBEntities();
            _view.LoginIntento += OnLoginIntento;
        }

        private void OnLoginIntento(object sender, EventArgs e)
        {
            // Busca el usuario en la tabla "usuarios"
            var usuario = _context.usuarios
                .FirstOrDefault(u => u.Usuario == _view.NombreUsuario &&
                                     u.Contrasena == _view.Contrasena);

            if (usuario != null)
            {
                _view.MostrarMensaje("Inicio de sesión exitoso ✅");

                // Abre el Dashboard
                var dashboard = new DashboardView();                     // 1) crear la vista
                var dashPresenter = new DashboardPresenter(dashboard);   // 2) crear el PRESENTER (suscribe eventos)
                dashboard.FormClosed += (_, __) =>                       // 3) qué pasa al cerrar hijos
                {
                    // Elige una:
                    // ((Form)_view).Show();    // volver al login
                    Application.Exit();         // o cerrar la app completa
                };
                dashboard.Show();

                // Oculta la ventana de login
                if (_view is Form loginForm)
                    loginForm.Hide();
            }
            else
            {
                _view.MostrarMensaje("Usuario o contraseña incorrectos ❌");
            }
        }
    }
}
