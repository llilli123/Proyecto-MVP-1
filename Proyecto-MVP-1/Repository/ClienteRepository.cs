using Proyecto_MVP_1.Interfaces;
using Proyecto_MVP_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MVP_1.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public List<cliente> ObtenerTodos()
        {
            using (var db = new RentalPrimeDBEntities())
            {
                return db.clientes.ToList();
            }
        }

        public cliente ObtenerPorId(int id)
        {
            using (var db = new RentalPrimeDBEntities())
            {
                return db.clientes.Find(id);
            }
        }

        public void Agregar(cliente c)
        {
            using (var db = new RentalPrimeDBEntities())
            {
                db.clientes.Add(c);
                db.SaveChanges();
            }
        }

        public void Actualizar(cliente c)
        {
            using (var db = new RentalPrimeDBEntities())
            {
                var existente = db.clientes.Find(c.ClienteId);
                if (existente != null)
                {
                    existente.NombreCompleto = c.NombreCompleto;
                    existente.Telefono = c.Telefono;
                    existente.Correo = c.Correo;
                    existente.Documento = c.Documento;
                    existente.Activo = c.Activo;
                    db.SaveChanges();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (var db = new RentalPrimeDBEntities())
            {
                var cliente = db.clientes.Find(id);
                if (cliente != null)
                {
                    db.clientes.Remove(cliente);
                    db.SaveChanges();
                }
            }
        }
    }
}
