using Proyecto_MVP_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MVP_1.Views.IviewCliente
{
    public interface IClienteView
    {
        // Datos que vienen de los controles
        int Id { get; set; }
        string Nombre { get; set; }
        string Telefono { get; set; }
        string Correo { get; set; }
        string Documento { get; set; }
        bool Activo { get; set; }

        // Métodos que actualizan la interfaz
        void MostrarClientes(List<cliente> clientes);
        void MostrarMensaje(string mensaje);

        // Eventos que el Presenter escuchará
        event EventHandler GuardarCliente;
        event EventHandler EditarCliente;
        event EventHandler EliminarCliente;
        event EventHandler CargarClientes;
    }
}
