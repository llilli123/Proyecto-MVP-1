using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_MVP_1.Views
{
    partial class DashboardView
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelSidebar;
        private PictureBox pictureBoxLogo;
        private Label labelAppTitle;
        private Label labelAppSubtitle;
        private Button buttonNavDashboard;
        private Button buttonNavClientes;
        private Button buttonNavEquipos;
        private Button buttonNavAlquileres;
        private Panel panelSidebarBottom;
        private Button buttonLogout;

        private Panel panelMain;
        private Label labelHeaderTitle;
        private Label labelHeaderSubtitle;

        private FlowLayoutPanel flowLayoutCards;
        private Panel cardDisponibles;
        private PictureBox iconDisponibles;
        private Label labelDisponiblesTitulo;
        private Label labelDisponiblesValor;

        private Panel cardAlquilados;
        private PictureBox iconAlquilados;
        private Label labelAlquiladosTitulo;
        private Label labelAlquiladosValor;

        private Panel cardActivos;
        private PictureBox iconActivos;
        private Label labelActivosTitulo;
        private Label labelActivosValor;

        private Panel cardIngresos;
        private PictureBox iconIngresos;
        private Label labelIngresosTitulo;
        private Label labelIngresosValor;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.labelAppSubtitle = new System.Windows.Forms.Label();
            this.buttonNavDashboard = new System.Windows.Forms.Button();
            this.buttonNavClientes = new System.Windows.Forms.Button();
            this.buttonNavEquipos = new System.Windows.Forms.Button();
            this.buttonNavAlquileres = new System.Windows.Forms.Button();
            this.panelSidebarBottom = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowLayoutCards = new System.Windows.Forms.FlowLayoutPanel();
            this.cardDisponibles = new System.Windows.Forms.Panel();
            this.iconDisponibles = new System.Windows.Forms.PictureBox();
            this.labelDisponiblesTitulo = new System.Windows.Forms.Label();
            this.labelDisponiblesValor = new System.Windows.Forms.Label();
            this.cardAlquilados = new System.Windows.Forms.Panel();
            this.iconAlquilados = new System.Windows.Forms.PictureBox();
            this.labelAlquiladosTitulo = new System.Windows.Forms.Label();
            this.labelAlquiladosValor = new System.Windows.Forms.Label();
            this.cardActivos = new System.Windows.Forms.Panel();
            this.iconActivos = new System.Windows.Forms.PictureBox();
            this.labelActivosTitulo = new System.Windows.Forms.Label();
            this.labelActivosValor = new System.Windows.Forms.Label();
            this.cardIngresos = new System.Windows.Forms.Panel();
            this.iconIngresos = new System.Windows.Forms.PictureBox();
            this.labelIngresosTitulo = new System.Windows.Forms.Label();
            this.labelIngresosValor = new System.Windows.Forms.Label();
            this.labelHeaderSubtitle = new System.Windows.Forms.Label();
            this.labelHeaderTitle = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelSidebarBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.flowLayoutCards.SuspendLayout();
            this.cardDisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDisponibles)).BeginInit();
            this.cardAlquilados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAlquilados)).BeginInit();
            this.cardActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconActivos)).BeginInit();
            this.cardIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(134)))));
            this.panelSidebar.Controls.Add(this.pictureBoxLogo);
            this.panelSidebar.Controls.Add(this.labelAppTitle);
            this.panelSidebar.Controls.Add(this.labelAppSubtitle);
            this.panelSidebar.Controls.Add(this.buttonNavDashboard);
            this.panelSidebar.Controls.Add(this.buttonNavClientes);
            this.panelSidebar.Controls.Add(this.buttonNavEquipos);
            this.panelSidebar.Controls.Add(this.buttonNavAlquileres);
            this.panelSidebar.Controls.Add(this.panelSidebarBottom);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(225, 720);
            this.panelSidebar.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(108)))), ((int)(((byte)(244)))));
            this.pictureBoxLogo.Location = new System.Drawing.Point(16, 16);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelAppTitle
            // 
            this.labelAppTitle.AutoSize = true;
            this.labelAppTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelAppTitle.ForeColor = System.Drawing.Color.White;
            this.labelAppTitle.Location = new System.Drawing.Point(64, 20);
            this.labelAppTitle.Name = "labelAppTitle";
            this.labelAppTitle.Size = new System.Drawing.Size(103, 23);
            this.labelAppTitle.TabIndex = 1;
            this.labelAppTitle.Text = "RentalPrime";
            // 
            // labelAppSubtitle
            // 
            this.labelAppSubtitle.AutoSize = true;
            this.labelAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelAppSubtitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAppSubtitle.Location = new System.Drawing.Point(64, 40);
            this.labelAppSubtitle.Name = "labelAppSubtitle";
            this.labelAppSubtitle.Size = new System.Drawing.Size(127, 19);
            this.labelAppSubtitle.TabIndex = 2;
            this.labelAppSubtitle.Text = "Gestión de Equipos";
            // 
            // buttonNavDashboard
            // 
            this.buttonNavDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(108)))), ((int)(((byte)(244)))));
            this.buttonNavDashboard.FlatAppearance.BorderSize = 0;
            this.buttonNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonNavDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonNavDashboard.Location = new System.Drawing.Point(0, 88);
            this.buttonNavDashboard.Name = "buttonNavDashboard";
            this.buttonNavDashboard.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonNavDashboard.Size = new System.Drawing.Size(225, 44);
            this.buttonNavDashboard.TabIndex = 3;
            this.buttonNavDashboard.Text = "Dashboard";
            this.buttonNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavDashboard.UseVisualStyleBackColor = false;
            // 
            // buttonNavClientes
            // 
            this.buttonNavClientes.FlatAppearance.BorderSize = 0;
            this.buttonNavClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavClientes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonNavClientes.ForeColor = System.Drawing.Color.White;
            this.buttonNavClientes.Location = new System.Drawing.Point(0, 136);
            this.buttonNavClientes.Name = "buttonNavClientes";
            this.buttonNavClientes.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonNavClientes.Size = new System.Drawing.Size(225, 44);
            this.buttonNavClientes.TabIndex = 4;
            this.buttonNavClientes.Text = "Clientes";
            this.buttonNavClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavClientes.UseVisualStyleBackColor = true;
            // 
            // buttonNavEquipos
            // 
            this.buttonNavEquipos.FlatAppearance.BorderSize = 0;
            this.buttonNavEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavEquipos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonNavEquipos.ForeColor = System.Drawing.Color.White;
            this.buttonNavEquipos.Location = new System.Drawing.Point(0, 184);
            this.buttonNavEquipos.Name = "buttonNavEquipos";
            this.buttonNavEquipos.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonNavEquipos.Size = new System.Drawing.Size(225, 44);
            this.buttonNavEquipos.TabIndex = 5;
            this.buttonNavEquipos.Text = "Equipos";
            this.buttonNavEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavEquipos.UseVisualStyleBackColor = true;
            // 
            // buttonNavAlquileres
            // 
            this.buttonNavAlquileres.FlatAppearance.BorderSize = 0;
            this.buttonNavAlquileres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavAlquileres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonNavAlquileres.ForeColor = System.Drawing.Color.White;
            this.buttonNavAlquileres.Location = new System.Drawing.Point(0, 232);
            this.buttonNavAlquileres.Name = "buttonNavAlquileres";
            this.buttonNavAlquileres.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonNavAlquileres.Size = new System.Drawing.Size(225, 44);
            this.buttonNavAlquileres.TabIndex = 6;
            this.buttonNavAlquileres.Text = "Alquileres";
            this.buttonNavAlquileres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavAlquileres.UseVisualStyleBackColor = true;
            // 
            // panelSidebarBottom
            // 
            this.panelSidebarBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.panelSidebarBottom.Controls.Add(this.buttonLogout);
            this.panelSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSidebarBottom.Location = new System.Drawing.Point(0, 656);
            this.panelSidebarBottom.Name = "panelSidebarBottom";
            this.panelSidebarBottom.Size = new System.Drawing.Size(225, 64);
            this.panelSidebarBottom.TabIndex = 7;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLogout.Location = new System.Drawing.Point(0, 0);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(225, 64);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "Cerrar sesión";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelMain.Controls.Add(this.flowLayoutCards);
            this.panelMain.Controls.Add(this.labelHeaderSubtitle);
            this.panelMain.Controls.Add(this.labelHeaderTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(225, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1253, 720);
            this.panelMain.TabIndex = 0;
            // 
            // flowLayoutCards
            // 
            this.flowLayoutCards.AutoScroll = true;
            this.flowLayoutCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.flowLayoutCards.Controls.Add(this.cardDisponibles);
            this.flowLayoutCards.Controls.Add(this.cardAlquilados);
            this.flowLayoutCards.Controls.Add(this.cardActivos);
            this.flowLayoutCards.Controls.Add(this.cardIngresos);
            this.flowLayoutCards.Location = new System.Drawing.Point(6, 88);
            this.flowLayoutCards.Name = "flowLayoutCards";
            this.flowLayoutCards.Padding = new System.Windows.Forms.Padding(12);
            this.flowLayoutCards.Size = new System.Drawing.Size(1192, 485);
            this.flowLayoutCards.TabIndex = 0;
            this.flowLayoutCards.WrapContents = false;
            // 
            // cardDisponibles
            // 
            this.cardDisponibles.BackColor = System.Drawing.Color.White;
            this.cardDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardDisponibles.Controls.Add(this.iconDisponibles);
            this.cardDisponibles.Controls.Add(this.labelDisponiblesTitulo);
            this.cardDisponibles.Controls.Add(this.labelDisponiblesValor);
            this.cardDisponibles.Location = new System.Drawing.Point(24, 24);
            this.cardDisponibles.Margin = new System.Windows.Forms.Padding(12);
            this.cardDisponibles.Name = "cardDisponibles";
            this.cardDisponibles.Size = new System.Drawing.Size(300, 100);
            this.cardDisponibles.TabIndex = 0;
            // 
            // iconDisponibles
            // 
            this.iconDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.iconDisponibles.Location = new System.Drawing.Point(16, 16);
            this.iconDisponibles.Name = "iconDisponibles";
            this.iconDisponibles.Size = new System.Drawing.Size(28, 28);
            this.iconDisponibles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconDisponibles.TabIndex = 0;
            this.iconDisponibles.TabStop = false;
            // 
            // labelDisponiblesTitulo
            // 
            this.labelDisponiblesTitulo.AutoSize = true;
            this.labelDisponiblesTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDisponiblesTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.labelDisponiblesTitulo.Location = new System.Drawing.Point(56, 20);
            this.labelDisponiblesTitulo.Name = "labelDisponiblesTitulo";
            this.labelDisponiblesTitulo.Size = new System.Drawing.Size(144, 20);
            this.labelDisponiblesTitulo.TabIndex = 1;
            this.labelDisponiblesTitulo.Text = "Equipos Disponibles";
            // 
            // labelDisponiblesValor
            // 
            this.labelDisponiblesValor.AutoSize = true;
            this.labelDisponiblesValor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.labelDisponiblesValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelDisponiblesValor.Location = new System.Drawing.Point(56, 50);
            this.labelDisponiblesValor.Name = "labelDisponiblesValor";
            this.labelDisponiblesValor.Size = new System.Drawing.Size(35, 28);
            this.labelDisponiblesValor.TabIndex = 2;
            this.labelDisponiblesValor.Text = "24";
            // 
            // cardAlquilados
            // 
            this.cardAlquilados.BackColor = System.Drawing.Color.White;
            this.cardAlquilados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardAlquilados.Controls.Add(this.iconAlquilados);
            this.cardAlquilados.Controls.Add(this.labelAlquiladosTitulo);
            this.cardAlquilados.Controls.Add(this.labelAlquiladosValor);
            this.cardAlquilados.Location = new System.Drawing.Point(348, 24);
            this.cardAlquilados.Margin = new System.Windows.Forms.Padding(12);
            this.cardAlquilados.Name = "cardAlquilados";
            this.cardAlquilados.Size = new System.Drawing.Size(300, 100);
            this.cardAlquilados.TabIndex = 1;
            // 
            // iconAlquilados
            // 
            this.iconAlquilados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.iconAlquilados.Location = new System.Drawing.Point(16, 16);
            this.iconAlquilados.Name = "iconAlquilados";
            this.iconAlquilados.Size = new System.Drawing.Size(28, 28);
            this.iconAlquilados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconAlquilados.TabIndex = 0;
            this.iconAlquilados.TabStop = false;
            // 
            // labelAlquiladosTitulo
            // 
            this.labelAlquiladosTitulo.AutoSize = true;
            this.labelAlquiladosTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelAlquiladosTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.labelAlquiladosTitulo.Location = new System.Drawing.Point(56, 20);
            this.labelAlquiladosTitulo.Name = "labelAlquiladosTitulo";
            this.labelAlquiladosTitulo.Size = new System.Drawing.Size(137, 20);
            this.labelAlquiladosTitulo.TabIndex = 1;
            this.labelAlquiladosTitulo.Text = "Equipos Alquilados";
            // 
            // labelAlquiladosValor
            // 
            this.labelAlquiladosValor.AutoSize = true;
            this.labelAlquiladosValor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.labelAlquiladosValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelAlquiladosValor.Location = new System.Drawing.Point(56, 50);
            this.labelAlquiladosValor.Name = "labelAlquiladosValor";
            this.labelAlquiladosValor.Size = new System.Drawing.Size(31, 28);
            this.labelAlquiladosValor.TabIndex = 2;
            this.labelAlquiladosValor.Text = "12";
            // 
            // cardActivos
            // 
            this.cardActivos.BackColor = System.Drawing.Color.White;
            this.cardActivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardActivos.Controls.Add(this.iconActivos);
            this.cardActivos.Controls.Add(this.labelActivosTitulo);
            this.cardActivos.Controls.Add(this.labelActivosValor);
            this.cardActivos.Location = new System.Drawing.Point(672, 24);
            this.cardActivos.Margin = new System.Windows.Forms.Padding(12);
            this.cardActivos.Name = "cardActivos";
            this.cardActivos.Size = new System.Drawing.Size(300, 100);
            this.cardActivos.TabIndex = 2;
            // 
            // iconActivos
            // 
            this.iconActivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.iconActivos.Location = new System.Drawing.Point(16, 16);
            this.iconActivos.Name = "iconActivos";
            this.iconActivos.Size = new System.Drawing.Size(28, 28);
            this.iconActivos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconActivos.TabIndex = 0;
            this.iconActivos.TabStop = false;
            // 
            // labelActivosTitulo
            // 
            this.labelActivosTitulo.AutoSize = true;
            this.labelActivosTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelActivosTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.labelActivosTitulo.Location = new System.Drawing.Point(56, 20);
            this.labelActivosTitulo.Name = "labelActivosTitulo";
            this.labelActivosTitulo.Size = new System.Drawing.Size(158, 20);
            this.labelActivosTitulo.TabIndex = 1;
            this.labelActivosTitulo.Text = "Alquileres Activos Hoy";
            // 
            // labelActivosValor
            // 
            this.labelActivosValor.AutoSize = true;
            this.labelActivosValor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.labelActivosValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelActivosValor.Location = new System.Drawing.Point(56, 50);
            this.labelActivosValor.Name = "labelActivosValor";
            this.labelActivosValor.Size = new System.Drawing.Size(23, 28);
            this.labelActivosValor.TabIndex = 2;
            this.labelActivosValor.Text = "8";
            // 
            // cardIngresos
            // 
            this.cardIngresos.BackColor = System.Drawing.Color.White;
            this.cardIngresos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardIngresos.Controls.Add(this.iconIngresos);
            this.cardIngresos.Controls.Add(this.labelIngresosTitulo);
            this.cardIngresos.Controls.Add(this.labelIngresosValor);
            this.cardIngresos.Location = new System.Drawing.Point(996, 24);
            this.cardIngresos.Margin = new System.Windows.Forms.Padding(12);
            this.cardIngresos.Name = "cardIngresos";
            this.cardIngresos.Size = new System.Drawing.Size(300, 100);
            this.cardIngresos.TabIndex = 3;
            // 
            // iconIngresos
            // 
            this.iconIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.iconIngresos.Location = new System.Drawing.Point(16, 16);
            this.iconIngresos.Name = "iconIngresos";
            this.iconIngresos.Size = new System.Drawing.Size(28, 28);
            this.iconIngresos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconIngresos.TabIndex = 0;
            this.iconIngresos.TabStop = false;
            // 
            // labelIngresosTitulo
            // 
            this.labelIngresosTitulo.AutoSize = true;
            this.labelIngresosTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelIngresosTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.labelIngresosTitulo.Location = new System.Drawing.Point(56, 20);
            this.labelIngresosTitulo.Name = "labelIngresosTitulo";
            this.labelIngresosTitulo.Size = new System.Drawing.Size(136, 20);
            this.labelIngresosTitulo.TabIndex = 1;
            this.labelIngresosTitulo.Text = "Ingresos Estimados";
            // 
            // labelIngresosValor
            // 
            this.labelIngresosValor.AutoSize = true;
            this.labelIngresosValor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.labelIngresosValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelIngresosValor.Location = new System.Drawing.Point(56, 50);
            this.labelIngresosValor.Name = "labelIngresosValor";
            this.labelIngresosValor.Size = new System.Drawing.Size(73, 28);
            this.labelIngresosValor.TabIndex = 2;
            this.labelIngresosValor.Text = "$4,250";
            // 
            // labelHeaderSubtitle
            // 
            this.labelHeaderSubtitle.AutoSize = true;
            this.labelHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelHeaderSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.labelHeaderSubtitle.Location = new System.Drawing.Point(15, 50);
            this.labelHeaderSubtitle.Name = "labelHeaderSubtitle";
            this.labelHeaderSubtitle.Size = new System.Drawing.Size(202, 20);
            this.labelHeaderSubtitle.TabIndex = 1;
            this.labelHeaderSubtitle.Text = "Resumen general del sistema";
            // 
            // labelHeaderTitle
            // 
            this.labelHeaderTitle.AutoSize = true;
            this.labelHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.labelHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelHeaderTitle.Location = new System.Drawing.Point(13, 16);
            this.labelHeaderTitle.Name = "labelHeaderTitle";
            this.labelHeaderTitle.Size = new System.Drawing.Size(167, 41);
            this.labelHeaderTitle.TabIndex = 2;
            this.labelHeaderTitle.Text = "Dashboard";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 720);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "DashboardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - RentalPrime";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelSidebarBottom.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.flowLayoutCards.ResumeLayout(false);
            this.cardDisponibles.ResumeLayout(false);
            this.cardDisponibles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDisponibles)).EndInit();
            this.cardAlquilados.ResumeLayout(false);
            this.cardAlquilados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAlquilados)).EndInit();
            this.cardActivos.ResumeLayout(false);
            this.cardActivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconActivos)).EndInit();
            this.cardIngresos.ResumeLayout(false);
            this.cardIngresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconIngresos)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}