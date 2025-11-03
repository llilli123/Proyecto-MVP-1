using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MVP_1.Presenters
{
    public interface ILoginView
    {
        string NombreUsuario { get; }
        string Contrasena { get; }
        void MostrarMensaje(string mensaje);
        event EventHandler LoginIntento;
    }
}
