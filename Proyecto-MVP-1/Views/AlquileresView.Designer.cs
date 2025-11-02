using System.Windows.Forms;

namespace Proyecto_MVP_1.Views
{
    partial class AlquileresView
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelTitulo;
        private Label labelSubtitulo;

        private Panel panelToolbar;
        private TextBox textBoxBuscar;
        private Label labelBuscarPlaceholder;
        private ComboBox comboFiltroCliente;
        private Button buttonFiltroDesplegar;

        private Panel panelTabla;
        private DataGridView dataGridViewAlquileres;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colEquipo;
        private DataGridViewTextBoxColumn colFechaInicio;
        private DataGridViewTextBoxColumn colFechaFin;
        private DataGridViewTextBoxColumn colPrecioDiario;
        private DataGridViewTextBoxColumn colDias;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewButtonColumn colEditar;
        private DataGridViewButtonColumn colEliminar;

        private Panel panelLateral;
        private Label labelPanelTitulo;
        private Label labelCliente;
        private ComboBox comboCliente;
        private Label labelEquipo;
        private ComboBox comboEquipo;
        private Label labelFechaInicio;
        private DateTimePicker dateInicio;
        private Label labelFechaFin;
        private DateTimePicker dateFin;
        private Label labelPrecioDiario;
        private TextBox textBoxPrecioDiario;
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
            this.comboFiltroCliente = new System.Windows.Forms.ComboBox();
            this.buttonFiltroDesplegar = new System.Windows.Forms.Button();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.dataGridViewAlquileres = new System.Windows.Forms.DataGridView();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioDiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.labelPanelTitulo = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.labelEquipo = new System.Windows.Forms.Label();
            this.comboEquipo = new System.Windows.Forms.ComboBox();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.labelPrecioDiario = new System.Windows.Forms.Label();
            this.textBoxPrecioDiario = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.panelToolbar.SuspendLayout();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).BeginInit();
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
            this.labelTitulo.Size = new System.Drawing.Size(309, 41);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Gestión de Alquileres";
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.labelSubtitulo.Location = new System.Drawing.Point(26, 52);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(250, 20);
            this.labelSubtitulo.TabIndex = 3;
            this.labelSubtitulo.Text = "Administra los alquileres de equipos";
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.Transparent;
            this.panelToolbar.Controls.Add(this.textBoxBuscar);
            this.panelToolbar.Controls.Add(this.labelBuscarPlaceholder);
            this.panelToolbar.Controls.Add(this.comboFiltroCliente);
            this.panelToolbar.Controls.Add(this.buttonFiltroDesplegar);
            this.panelToolbar.Location = new System.Drawing.Point(20, 80);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(980, 44);
            this.panelToolbar.TabIndex = 2;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxBuscar.Location = new System.Drawing.Point(118, 5);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(560, 29);
            this.textBoxBuscar.TabIndex = 1;
            // 
            // labelBuscarPlaceholder
            // 
            this.labelBuscarPlaceholder.AutoSize = true;
            this.labelBuscarPlaceholder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelBuscarPlaceholder.ForeColor = System.Drawing.Color.Silver;
            this.labelBuscarPlaceholder.Location = new System.Drawing.Point(128, 9);
            this.labelBuscarPlaceholder.Name = "labelBuscarPlaceholder";
            this.labelBuscarPlaceholder.Size = new System.Drawing.Size(115, 20);
            this.labelBuscarPlaceholder.TabIndex = 2;
            this.labelBuscarPlaceholder.Text = "Buscar alquiler...";
            // 
            // comboFiltroCliente
            // 
            this.comboFiltroCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltroCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboFiltroCliente.Location = new System.Drawing.Point(700, 5);
            this.comboFiltroCliente.Name = "comboFiltroCliente";
            this.comboFiltroCliente.Size = new System.Drawing.Size(200, 28);
            this.comboFiltroCliente.TabIndex = 3;
            // 
            // buttonFiltroDesplegar
            // 
            this.buttonFiltroDesplegar.FlatAppearance.BorderSize = 0;
            this.buttonFiltroDesplegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltroDesplegar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonFiltroDesplegar.Location = new System.Drawing.Point(904, 5);
            this.buttonFiltroDesplegar.Name = "buttonFiltroDesplegar";
            this.buttonFiltroDesplegar.Size = new System.Drawing.Size(24, 23);
            this.buttonFiltroDesplegar.TabIndex = 4;
            this.buttonFiltroDesplegar.Text = "▼";
            this.buttonFiltroDesplegar.UseVisualStyleBackColor = true;
            // 
            // panelTabla
            // 
            this.panelTabla.BackColor = System.Drawing.Color.White;
            this.panelTabla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTabla.Controls.Add(this.dataGridViewAlquileres);
            this.panelTabla.Location = new System.Drawing.Point(20, 132);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(980, 530);
            this.panelTabla.TabIndex = 1;
            // 
            // dataGridViewAlquileres
            // 
            this.dataGridViewAlquileres.AllowUserToAddRows = false;
            this.dataGridViewAlquileres.AllowUserToDeleteRows = false;
            this.dataGridViewAlquileres.AllowUserToResizeRows = false;
            this.dataGridViewAlquileres.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAlquileres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAlquileres.ColumnHeadersHeight = 36;
            this.dataGridViewAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAlquileres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCliente,
            this.colEquipo,
            this.colFechaInicio,
            this.colFechaFin,
            this.colPrecioDiario,
            this.colDias,
            this.colTotal,
            this.colEstado,
            this.colEditar,
            this.colEliminar});
            this.dataGridViewAlquileres.EnableHeadersVisualStyles = false;
            this.dataGridViewAlquileres.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewAlquileres.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewAlquileres.MultiSelect = false;
            this.dataGridViewAlquileres.Name = "dataGridViewAlquileres";
            this.dataGridViewAlquileres.ReadOnly = true;
            this.dataGridViewAlquileres.RowHeadersVisible = false;
            this.dataGridViewAlquileres.RowHeadersWidth = 51;
            this.dataGridViewAlquileres.RowTemplate.Height = 30;
            this.dataGridViewAlquileres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlquileres.Size = new System.Drawing.Size(958, 508);
            this.dataGridViewAlquileres.TabIndex = 0;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 6;
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.Width = 140;
            // 
            // colEquipo
            // 
            this.colEquipo.HeaderText = "Equipo";
            this.colEquipo.MinimumWidth = 6;
            this.colEquipo.Name = "colEquipo";
            this.colEquipo.ReadOnly = true;
            this.colEquipo.Width = 160;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.HeaderText = "Fecha Inicio";
            this.colFechaInicio.MinimumWidth = 6;
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.ReadOnly = true;
            this.colFechaInicio.Width = 110;
            // 
            // colFechaFin
            // 
            this.colFechaFin.HeaderText = "Fecha Fin";
            this.colFechaFin.MinimumWidth = 6;
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.ReadOnly = true;
            this.colFechaFin.Width = 110;
            // 
            // colPrecioDiario
            // 
            this.colPrecioDiario.HeaderText = "Precio Diario";
            this.colPrecioDiario.MinimumWidth = 6;
            this.colPrecioDiario.Name = "colPrecioDiario";
            this.colPrecioDiario.ReadOnly = true;
            this.colPrecioDiario.Width = 95;
            // 
            // colDias
            // 
            this.colDias.HeaderText = "Días";
            this.colDias.MinimumWidth = 6;
            this.colDias.Name = "colDias";
            this.colDias.ReadOnly = true;
            this.colDias.Width = 60;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 90;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 90;
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
            this.panelLateral.Controls.Add(this.labelCliente);
            this.panelLateral.Controls.Add(this.comboCliente);
            this.panelLateral.Controls.Add(this.labelEquipo);
            this.panelLateral.Controls.Add(this.comboEquipo);
            this.panelLateral.Controls.Add(this.labelFechaInicio);
            this.panelLateral.Controls.Add(this.dateInicio);
            this.panelLateral.Controls.Add(this.labelFechaFin);
            this.panelLateral.Controls.Add(this.dateFin);
            this.panelLateral.Controls.Add(this.labelPrecioDiario);
            this.panelLateral.Controls.Add(this.textBoxPrecioDiario);
            this.panelLateral.Controls.Add(this.buttonGuardar);
            this.panelLateral.Location = new System.Drawing.Point(1016, 24);
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
            this.labelPanelTitulo.Size = new System.Drawing.Size(138, 25);
            this.labelPanelTitulo.TabIndex = 0;
            this.labelPanelTitulo.Text = "Nuevo Alquiler";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCliente.ForeColor = System.Drawing.Color.DimGray;
            this.labelCliente.Location = new System.Drawing.Point(16, 56);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(55, 20);
            this.labelCliente.TabIndex = 1;
            this.labelCliente.Text = "Cliente";
            // 
            // comboCliente
            // 
            this.comboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboCliente.Location = new System.Drawing.Point(16, 76);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(266, 28);
            this.comboCliente.TabIndex = 2;
            // 
            // labelEquipo
            // 
            this.labelEquipo.AutoSize = true;
            this.labelEquipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelEquipo.ForeColor = System.Drawing.Color.DimGray;
            this.labelEquipo.Location = new System.Drawing.Point(16, 112);
            this.labelEquipo.Name = "labelEquipo";
            this.labelEquipo.Size = new System.Drawing.Size(56, 20);
            this.labelEquipo.TabIndex = 3;
            this.labelEquipo.Text = "Equipo";
            // 
            // comboEquipo
            // 
            this.comboEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEquipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboEquipo.Location = new System.Drawing.Point(16, 132);
            this.comboEquipo.Name = "comboEquipo";
            this.comboEquipo.Size = new System.Drawing.Size(266, 28);
            this.comboEquipo.TabIndex = 4;
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelFechaInicio.ForeColor = System.Drawing.Color.DimGray;
            this.labelFechaInicio.Location = new System.Drawing.Point(16, 168);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(108, 20);
            this.labelFechaInicio.TabIndex = 5;
            this.labelFechaInicio.Text = "Fecha de inicio";
            // 
            // dateInicio
            // 
            this.dateInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicio.Location = new System.Drawing.Point(16, 188);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(266, 27);
            this.dateInicio.TabIndex = 6;
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelFechaFin.ForeColor = System.Drawing.Color.DimGray;
            this.labelFechaFin.Location = new System.Drawing.Point(16, 224);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(89, 20);
            this.labelFechaFin.TabIndex = 7;
            this.labelFechaFin.Text = "Fecha de fin";
            // 
            // dateFin
            // 
            this.dateFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFin.Location = new System.Drawing.Point(16, 244);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(266, 27);
            this.dateFin.TabIndex = 8;
            // 
            // labelPrecioDiario
            // 
            this.labelPrecioDiario.AutoSize = true;
            this.labelPrecioDiario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelPrecioDiario.ForeColor = System.Drawing.Color.DimGray;
            this.labelPrecioDiario.Location = new System.Drawing.Point(16, 280);
            this.labelPrecioDiario.Name = "labelPrecioDiario";
            this.labelPrecioDiario.Size = new System.Drawing.Size(115, 20);
            this.labelPrecioDiario.TabIndex = 9;
            this.labelPrecioDiario.Text = "Precio diario ($)";
            // 
            // textBoxPrecioDiario
            // 
            this.textBoxPrecioDiario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrecioDiario.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxPrecioDiario.Location = new System.Drawing.Point(16, 300);
            this.textBoxPrecioDiario.Name = "textBoxPrecioDiario";
            this.textBoxPrecioDiario.Size = new System.Drawing.Size(266, 29);
            this.textBoxPrecioDiario.TabIndex = 10;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(108)))), ((int)(((byte)(244)))));
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(16, 340);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(266, 36);
            this.buttonGuardar.TabIndex = 11;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // AlquileresView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1332, 686);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.labelSubtitulo);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "AlquileresView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquileres - RentalPrime";
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}