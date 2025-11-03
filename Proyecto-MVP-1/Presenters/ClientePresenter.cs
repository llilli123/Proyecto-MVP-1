using Proyecto_MVP_1.Interfaces;
using Proyecto_MVP_1.Models.Entities;
using Proyecto_MVP_1.Views.IviewCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MVP_1.Presenters
{
    public class ClientePresenter
    {
        private readonly IClienteView _view;
        private readonly IClienteRepository _repository;

        public ClientePresenter(IClienteView view, IClienteRepository repository)
        {
            _view = view;
            _repository = repository;

            // Suscripción de eventos
            _view.GuardarCliente += OnGuardarCliente;
            _view.EditarCliente += OnEditarCliente;
            _view.EliminarCliente += OnEliminarCliente;
            _view.CargarClientes += OnCargarClientes;
        }

        private void OnCargarClientes(object sender, EventArgs e)
        {
            var lista = _repository.ObtenerTodos();
            _view.MostrarClientes(lista);
        }

        private void OnGuardarCliente(object sender, EventArgs e)
        {
            try
            {
                var nuevo = new cliente
                {
                    NombreCompleto = _view.Nombre,
                    Telefono = _view.Telefono,
                    Correo = _view.Correo,
                    Documento = _view.Documento,
                    Activo = _view.Activo
                };

                _repository.Agregar(nuevo);
                _view.MostrarMensaje("Cliente agregado correctamente.");
                OnCargarClientes(sender, e);
            }
            catch (Exception ex)
            {
                _view.MostrarMensaje("Error al guardar: " + ex.Message);
            }
        }

        private void OnEditarCliente(object sender, EventArgs e)
        {
            try
            {
                var actualizado = new cliente
                {
                    ClienteId = _view.Id,
                    NombreCompleto = _view.Nombre,
                    Telefono = _view.Telefono,
                    Correo = _view.Correo,
                    Documento = _view.Documento,
                    Activo = _view.Activo
                };

                _repository.Actualizar(actualizado);
                _view.MostrarMensaje("Cliente actualizado correctamente.");
                OnCargarClientes(sender, e);
            }
            catch (Exception ex)
            {
                _view.MostrarMensaje("Error al editar: " + ex.Message);
            }
        }

        private void OnEliminarCliente(object sender, EventArgs e)
        {
            try
            {
                _repository.Eliminar(_view.Id);
                _view.MostrarMensaje("Cliente eliminado correctamente.");
                OnCargarClientes(sender, e);
            }
            catch (Exception ex)
            {
                _view.MostrarMensaje("Error al eliminar: " + ex.Message);
            }
        }
    }
}
