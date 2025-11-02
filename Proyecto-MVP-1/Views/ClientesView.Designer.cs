using System.Windows.Forms;

namespace Proyecto_MVP_1.Views
{
    partial class ClientesView
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelTitulo;
        private Label labelSubtitulo;

        private Panel panelToolbar;
        private TextBox textBoxBuscar;
        private Label labelBuscarPlaceholder;

        private Panel panelTabla;
        private DataGridView dataGridViewClientes;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colDocumento;
        private DataGridViewTextBoxColumn colActivo;
        private DataGridViewButtonColumn colEditar;
        private DataGridViewButtonColumn colEliminar;

        private Panel panelLateral;
        private Label labelPanelTitulo;
        private Label labelNombre;
        private TextBox textBoxNombre;
        private Label labelTelefono;
        private TextBox textBoxTelefono;
        private Label labelCorreo;
        private TextBox textBoxCorreo;
        private Label labelDocumento;
        private TextBox textBoxDocumento;
        private CheckBox checkBoxActivo;
        private Panel panelSeparador;
        private Button buttonGuardar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelSubtitulo = new System.Windows.Forms.Label();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscarPlaceholder = new System.Windows.Forms.Label();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.labelPanelTitulo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.panelSeparador = new System.Windows.Forms.Panel();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.panelToolbar.SuspendLayout();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelTitulo.Location = new System.Drawing.Point(24, 16);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(282, 41);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Gestión de Clientes";
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.labelSubtitulo.Location = new System.Drawing.Point(26, 52);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(279, 20);
            this.labelSubtitulo.TabIndex = 3;
            this.labelSubtitulo.Text = "Administra la información de tus clientes";
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.Transparent;
            this.panelToolbar.Controls.Add(this.textBoxBuscar);
            this.panelToolbar.Controls.Add(this.labelBuscarPlaceholder);
            this.panelToolbar.Location = new System.Drawing.Point(20, 80);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(830, 44);
            this.panelToolbar.TabIndex = 2;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxBuscar.Location = new System.Drawing.Point(118, 5);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(700, 29);
            this.textBoxBuscar.TabIndex = 1;
            // 
            // labelBuscarPlaceholder
            // 
            this.labelBuscarPlaceholder.AutoSize = true;
            this.labelBuscarPlaceholder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelBuscarPlaceholder.ForeColor = System.Drawing.Color.Silver;
            this.labelBuscarPlaceholder.Location = new System.Drawing.Point(128, 9);
            this.labelBuscarPlaceholder.Name = "labelBuscarPlaceholder";
            this.labelBuscarPlaceholder.Size = new System.Drawing.Size(109, 20);
            this.labelBuscarPlaceholder.TabIndex = 2;
            this.labelBuscarPlaceholder.Text = "Buscar cliente...";
            // 
            // panelTabla
            // 
            this.panelTabla.BackColor = System.Drawing.Color.White;
            this.panelTabla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTabla.Controls.Add(this.dataGridViewClientes);
            this.panelTabla.Location = new System.Drawing.Point(20, 132);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(830, 530);
            this.panelTabla.TabIndex = 1;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.AllowUserToResizeRows = false;
            this.dataGridViewClientes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClientes.ColumnHeadersHeight = 36;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colTelefono,
            this.colCorreo,
            this.colDocumento,
            this.colActivo,
            this.colEditar,
            this.colEliminar});
            this.dataGridViewClientes.EnableHeadersVisualStyles = false;
            this.dataGridViewClientes.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewClientes.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewClientes.MultiSelect = false;
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.RowHeadersVisible = false;
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.Height = 30;
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.Size = new System.Drawing.Size(808, 508);
            this.dataGridViewClientes.TabIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.FillWeight = 160F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.MinimumWidth = 6;
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            this.colTelefono.Width = 120;
            // 
            // colCorreo
            // 
            this.colCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCorreo.FillWeight = 140F;
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.MinimumWidth = 6;
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            // 
            // colDocumento
            // 
            this.colDocumento.HeaderText = "Documento";
            this.colDocumento.MinimumWidth = 6;
            this.colDocumento.Name = "colDocumento";
            this.colDocumento.ReadOnly = true;
            this.colDocumento.Width = 130;
            // 
            // colActivo
            // 
            this.colActivo.HeaderText = "Activo";
            this.colActivo.MinimumWidth = 6;
            this.colActivo.Name = "colActivo";
            this.colActivo.ReadOnly = true;
            this.colActivo.Width = 70;
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "Editar";
            this.colEditar.MinimumWidth = 6;
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Text = "✎";
            this.colEditar.UseColumnTextForButtonValue = true;
            this.colEditar.Width = 60;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.MinimumWidth = 6;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.ReadOnly = true;
            this.colEliminar.Text = "🗑";
            this.colEliminar.UseColumnTextForButtonValue = true;
            this.colEliminar.Width = 70;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.White;
            this.panelLateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLateral.Controls.Add(this.labelPanelTitulo);
            this.panelLateral.Controls.Add(this.labelNombre);
            this.panelLateral.Controls.Add(this.textBoxNombre);
            this.panelLateral.Controls.Add(this.labelTelefono);
            this.panelLateral.Controls.Add(this.textBoxTelefono);
            this.panelLateral.Controls.Add(this.labelCorreo);
            this.panelLateral.Controls.Add(this.textBoxCorreo);
            this.panelLateral.Controls.Add(this.labelDocumento);
            this.panelLateral.Controls.Add(this.textBoxDocumento);
            this.panelLateral.Controls.Add(this.checkBoxActivo);
            this.panelLateral.Controls.Add(this.panelSeparador);
            this.panelLateral.Controls.Add(this.buttonGuardar);
            this.panelLateral.Location = new System.Drawing.Point(868, 24);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(300, 638);
            this.panelLateral.TabIndex = 0;
            // 
            // labelPanelTitulo
            // 
            this.labelPanelTitulo.AutoSize = true;
            this.labelPanelTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelPanelTitulo.Location = new System.Drawing.Point(16, 16);
            this.labelPanelTitulo.Name = "labelPanelTitulo";
            this.labelPanelTitulo.Size = new System.Drawing.Size(131, 25);
            this.labelPanelTitulo.TabIndex = 0;
            this.labelPanelTitulo.Text = "Nuevo Cliente";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelNombre.ForeColor = System.Drawing.Color.DimGray;
            this.labelNombre.Location = new System.Drawing.Point(16, 56);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(132, 20);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre completo";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxNombre.Location = new System.Drawing.Point(16, 76);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(266, 29);
            this.textBoxNombre.TabIndex = 2;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.labelTelefono.Location = new System.Drawing.Point(16, 112);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(67, 20);
            this.labelTelefono.TabIndex = 3;
            this.labelTelefono.Text = "Teléfono";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTelefono.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxTelefono.Location = new System.Drawing.Point(16, 132);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(266, 29);
            this.textBoxTelefono.TabIndex = 4;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.labelCorreo.Location = new System.Drawing.Point(16, 168);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(132, 20);
            this.labelCorreo.TabIndex = 5;
            this.labelCorreo.Text = "Correo electrónico";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCorreo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxCorreo.Location = new System.Drawing.Point(16, 188);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(266, 29);
            this.textBoxCorreo.TabIndex = 6;
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDocumento.ForeColor = System.Drawing.Color.DimGray;
            this.labelDocumento.Location = new System.Drawing.Point(16, 224);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(87, 20);
            this.labelDocumento.TabIndex = 7;
            this.labelDocumento.Text = "Documento";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDocumento.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxDocumento.Location = new System.Drawing.Point(16, 244);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(266, 29);
            this.textBoxDocumento.TabIndex = 8;
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxActivo.Location = new System.Drawing.Point(16, 284);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(121, 24);
            this.checkBoxActivo.TabIndex = 9;
            this.checkBoxActivo.Text = "Cliente activo";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // panelSeparador
            // 
            this.panelSeparador.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSeparador.Location = new System.Drawing.Point(16, 318);
            this.panelSeparador.Name = "panelSeparador";
            this.panelSeparador.Size = new System.Drawing.Size(266, 1);
            this.panelSeparador.TabIndex = 10;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(108)))), ((int)(((byte)(244)))));
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(16, 338);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(266, 36);
            this.buttonGuardar.TabIndex = 11;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // ClientesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1188, 686);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.labelSubtitulo);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ClientesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes - RentalPrime";
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}