using Proyecto_MVP_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MVP_1.Interfaces
{
    public interface IClienteRepository
    {
        List<cliente> ObtenerTodos();
        cliente ObtenerPorId(int id);
        void Agregar(cliente cliente);
        void Actualizar(cliente cliente);
        void Eliminar(int id);
    }
}
