using System.Windows.Forms;

namespace Proyecto_MVP_1.Views
{
    partial class EquiposView
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelTitulo;
        private Label labelSubtitulo;

        private Panel panelToolbar;
        private TextBox textBoxBuscar;
        private Label labelBuscarPlaceholder;
        private ComboBox comboFiltroEstado;
        private Button buttonFiltroDesplegar;

        private Panel panelTabla;
        private DataGridView dataGridViewEquipos;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colActivo;
        private DataGridViewButtonColumn colEditar;
        private DataGridViewButtonColumn colEliminar;

        private Panel panelLateral;
        private Label labelPanelTitulo;
        private Label labelNombre;
        private TextBox textBoxNombre;
        private Label labelCategoria;
        private TextBox textBoxCategoria;
        private Label labelEstado;
        private ComboBox comboEstado;
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
            this.comboFiltroEstado = new System.Windows.Forms.ComboBox();
            this.buttonFiltroDesplegar = new System.Windows.Forms.Button();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.dataGridViewEquipos = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.labelPanelTitulo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.panelSeparador = new System.Windows.Forms.Panel();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.panelToolbar.SuspendLayout();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipos)).BeginInit();
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
            this.labelTitulo.Text = "Gestión de Equipos";
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.labelSubtitulo.Location = new System.Drawing.Point(26, 52);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(246, 20);
            this.labelSubtitulo.TabIndex = 3;
            this.labelSubtitulo.Text = "Administra tu inventario de equipos";
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.Transparent;
            this.panelToolbar.Controls.Add(this.textBoxBuscar);
            this.panelToolbar.Controls.Add(this.labelBuscarPlaceholder);
            this.panelToolbar.Controls.Add(this.comboFiltroEstado);
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
            this.labelBuscarPlaceholder.Size = new System.Drawing.Size(112, 20);
            this.labelBuscarPlaceholder.TabIndex = 2;
            this.labelBuscarPlaceholder.Text = "Buscar equipo...";
            // 
            // comboFiltroEstado
            // 
            this.comboFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltroEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboFiltroEstado.Location = new System.Drawing.Point(700, 5);
            this.comboFiltroEstado.Name = "comboFiltroEstado";
            this.comboFiltroEstado.Size = new System.Drawing.Size(200, 28);
            this.comboFiltroEstado.TabIndex = 3;
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
            this.panelTabla.Controls.Add(this.dataGridViewEquipos);
            this.panelTabla.Location = new System.Drawing.Point(20, 132);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(980, 530);
            this.panelTabla.TabIndex = 1;
            // 
            // dataGridViewEquipos
            // 
            this.dataGridViewEquipos.AllowUserToAddRows = false;
            this.dataGridViewEquipos.AllowUserToDeleteRows = false;
            this.dataGridViewEquipos.AllowUserToResizeRows = false;
            this.dataGridViewEquipos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEquipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEquipos.ColumnHeadersHeight = 36;
            this.dataGridViewEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colCategoria,
            this.colEstado,
            this.colActivo,
            this.colEditar,
            this.colEliminar});
            this.dataGridViewEquipos.EnableHeadersVisualStyles = false;
            this.dataGridViewEquipos.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewEquipos.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewEquipos.MultiSelect = false;
            this.dataGridViewEquipos.Name = "dataGridViewEquipos";
            this.dataGridViewEquipos.ReadOnly = true;
            this.dataGridViewEquipos.RowHeadersVisible = false;
            this.dataGridViewEquipos.RowHeadersWidth = 51;
            this.dataGridViewEquipos.RowTemplate.Height = 30;
            this.dataGridViewEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEquipos.Size = new System.Drawing.Size(958, 508);
            this.dataGridViewEquipos.TabIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.FillWeight = 170F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCategoria.FillWeight = 150F;
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.MinimumWidth = 6;
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 160;
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
            this.panelLateral.Controls.Add(this.labelCategoria);
            this.panelLateral.Controls.Add(this.textBoxCategoria);
            this.panelLateral.Controls.Add(this.labelEstado);
            this.panelLateral.Controls.Add(this.comboEstado);
            this.panelLateral.Controls.Add(this.checkBoxActivo);
            this.panelLateral.Controls.Add(this.panelSeparador);
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
            this.labelPanelTitulo.Size = new System.Drawing.Size(130, 25);
            this.labelPanelTitulo.TabIndex = 0;
            this.labelPanelTitulo.Text = "Nuevo Equipo";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelNombre.ForeColor = System.Drawing.Color.DimGray;
            this.labelNombre.Location = new System.Drawing.Point(16, 56);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(140, 20);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre del equipo";
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
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCategoria.ForeColor = System.Drawing.Color.DimGray;
            this.labelCategoria.Location = new System.Drawing.Point(16, 112);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(74, 20);
            this.labelCategoria.TabIndex = 3;
            this.labelCategoria.Text = "Categoría";
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCategoria.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxCategoria.Location = new System.Drawing.Point(16, 132);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(266, 29);
            this.textBoxCategoria.TabIndex = 4;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelEstado.ForeColor = System.Drawing.Color.DimGray;
            this.labelEstado.Location = new System.Drawing.Point(16, 168);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(54, 20);
            this.labelEstado.TabIndex = 5;
            this.labelEstado.Text = "Estado";
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboEstado.Location = new System.Drawing.Point(16, 188);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(266, 28);
            this.comboEstado.TabIndex = 6;
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxActivo.Location = new System.Drawing.Point(16, 224);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(122, 24);
            this.checkBoxActivo.TabIndex = 7;
            this.checkBoxActivo.Text = "Equipo activo";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // panelSeparador
            // 
            this.panelSeparador.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSeparador.Location = new System.Drawing.Point(16, 258);
            this.panelSeparador.Name = "panelSeparador";
            this.panelSeparador.Size = new System.Drawing.Size(266, 1);
            this.panelSeparador.TabIndex = 8;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(108)))), ((int)(((byte)(244)))));
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(16, 278);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(266, 36);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // EquiposView
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
            this.Name = "EquiposView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipos - RentalPrime";
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipos)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}