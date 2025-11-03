using System;

namespace Proyecto_MVP_1.Views.Interfaces
{
    public interface IDashboardView
    {
        // --- ELIMINAMOS LAS PROPIEDADES "set" ---
        // Ya no las necesitamos.

        // --- Eventos para las Acciones ---
        // Dejamos solo los eventos de los botones
        event EventHandler NavigateToClientes;
        event EventHandler NavigateToEquipos;
        event EventHandler NavigateToAlquileres;
        event EventHandler Logout;

        // --- Métodos de control ---
        void Show();
        void Hide();
        void Close();
    }
}