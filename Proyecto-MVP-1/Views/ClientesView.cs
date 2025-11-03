using Proyecto_MVP_1.Models.Entities;
using Proyecto_MVP_1.Views.IviewCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MVP_1.Views
{
    public partial class ClientesView : Form, IClienteView
    {
        

        public ClientesView()
        {
            InitializeComponent();
            var repo = new Repository.ClienteRepository();
            var presenter = new Presenters.ClientePresenter(this, repo);
            CargarClientes?.Invoke(this, EventArgs.Empty);
            
        }
        public int Id { get; set; }

        public string Nombre
        {
            get => textBoxNombre.Text;
            set => textBoxNombre.Text = value;
        }

        public string Telefono
        {
            get => textBoxTelefono.Text;
            set => textBoxTelefono.Text = value;
        }

        public string Correo
        {
            get => textBoxCorreo.Text;
            set => textBoxCorreo.Text = value;
        }

        public string Documento
        {
            get => textBoxDocumento.Text;
            set => textBoxDocumento.Text = value;
        }

        public bool Activo
        {
            get => checkBoxActivo.Checked;
            set => checkBoxActivo.Checked = value;
        }


        public event EventHandler GuardarCliente;
        public event EventHandler EditarCliente;
        public event EventHandler EliminarCliente;
        public event EventHandler CargarClientes;

        public void MostrarClientes(List<cliente> clientes)
        {
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = clientes;
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false; // evita
            
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarCliente?.Invoke(this, EventArgs.Empty);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCliente?.Invoke(this, EventArgs.Empty);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            GuardarCliente?.Invoke(this, EventArgs.Empty);
        }
    }
}

