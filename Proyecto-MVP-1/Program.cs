using ProyectoLoginMVP.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MVP_1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear la vista
            var loginView = new LoginView();

            // Crear el presenter y asociarlo a la vista
            var loginPresenter = new LoginPresenter(loginView);

            // Ejecutar la aplicación con la vista
            Application.Run(loginView);
        }
    }
}
