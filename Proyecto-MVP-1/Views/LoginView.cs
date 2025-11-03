using Proyecto_MVP_1.Presenters;
using ProyectoLoginMVP.Presenters;
using System;
using System.Windows.Forms;

namespace Proyecto_MVP_1
{
    
    public partial class LoginView : Form, ILoginView
    {
        // Evento que el Presenter escuchará
        public event EventHandler LoginIntento;

        public string NombreUsuario => txtUser.Text;
        public string Contrasena => txtPassword.Text;

        public LoginView()
        {
            InitializeComponent();

            // Suscribimos el botón al evento
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginIntento?.Invoke(sender, e);
        }
    }
}
