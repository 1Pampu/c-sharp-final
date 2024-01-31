namespace Proyecto2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GBoxAgregar = new System.Windows.Forms.GroupBox();
            this.lblAgregarTipovehiculo = new System.Windows.Forms.Label();
            this.comboBoxAgregar1 = new System.Windows.Forms.ComboBox();
            this.panelAgregarDatos = new System.Windows.Forms.Panel();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.lblAgregarColor = new System.Windows.Forms.Label();
            this.txtBoxColor = new System.Windows.Forms.TextBox();
            this.lblAgregarKm = new System.Windows.Forms.Label();
            this.numKm = new System.Windows.Forms.NumericUpDown();
            this.lblAgregarAnio = new System.Windows.Forms.Label();
            this.numAnio = new System.Windows.Forms.NumericUpDown();
            this.lblAgregarDuenio = new System.Windows.Forms.Label();
            this.txtBoxDuenio = new System.Windows.Forms.TextBox();
            this.lblAgregarAlerta = new System.Windows.Forms.Label();
            this.panelAgregarModelo = new System.Windows.Forms.Panel();
            this.lblAgregarModelo = new System.Windows.Forms.Label();
            this.comboBoxAgregar2 = new System.Windows.Forms.ComboBox();
            this.dataGridVehiculos = new System.Windows.Forms.DataGridView();
            this.GBoxGenerar = new System.Windows.Forms.GroupBox();
            this.bttnGenerarSpacex = new System.Windows.Forms.Button();
            this.bttnGenerarTesla = new System.Windows.Forms.Button();
            this.lblGridTitulo = new System.Windows.Forms.Label();
            this.bttnCambiarLista = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.dataGridTeslaKm = new System.Windows.Forms.DataGridView();
            this.lblTeslaKm = new System.Windows.Forms.Label();
            this.lblEliminarAlerta = new System.Windows.Forms.Label();
            this.bttnScan = new System.Windows.Forms.Button();
            this.GBoxScan = new System.Windows.Forms.GroupBox();
            this.LogoImage = new System.Windows.Forms.PictureBox();
            this.dataGridService = new System.Windows.Forms.DataGridView();
            this.lblService = new System.Windows.Forms.Label();
            this.lblAsientos = new System.Windows.Forms.Label();
            this.lblAutonomia = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblScanAlerta = new System.Windows.Forms.Label();
            this.GBoxAgregar.SuspendLayout();
            this.panelAgregarDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).BeginInit();
            this.panelAgregarModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehiculos)).BeginInit();
            this.GBoxGenerar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeslaKm)).BeginInit();
            this.GBoxScan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).BeginInit();
            this.SuspendLayout();
            // 
            // GBoxAgregar
            // 
            this.GBoxAgregar.Controls.Add(this.lblAgregarTipovehiculo);
            this.GBoxAgregar.Controls.Add(this.comboBoxAgregar1);
            this.GBoxAgregar.Location = new System.Drawing.Point(12, 9);
            this.GBoxAgregar.Name = "GBoxAgregar";
            this.GBoxAgregar.Size = new System.Drawing.Size(228, 249);
            this.GBoxAgregar.TabIndex = 0;
            this.GBoxAgregar.TabStop = false;
            this.GBoxAgregar.Text = "Agregar";
            // 
            // lblAgregarTipovehiculo
            // 
            this.lblAgregarTipovehiculo.AutoSize = true;
            this.lblAgregarTipovehiculo.Location = new System.Drawing.Point(12, 16);
            this.lblAgregarTipovehiculo.Name = "lblAgregarTipovehiculo";
            this.lblAgregarTipovehiculo.Size = new System.Drawing.Size(89, 13);
            this.lblAgregarTipovehiculo.TabIndex = 0;
            this.lblAgregarTipovehiculo.Text = "Tipo de Vehículo";
            // 
            // comboBoxAgregar1
            // 
            this.comboBoxAgregar1.FormattingEnabled = true;
            this.comboBoxAgregar1.Items.AddRange(new object[] {
            "Tesla",
            "SpaceX"});
            this.comboBoxAgregar1.Location = new System.Drawing.Point(15, 32);
            this.comboBoxAgregar1.Name = "comboBoxAgregar1";
            this.comboBoxAgregar1.Size = new System.Drawing.Size(155, 21);
            this.comboBoxAgregar1.TabIndex = 3;
            this.comboBoxAgregar1.Text = "- Seleccione una opcion -";
            this.comboBoxAgregar1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgregar1_SelectedIndexChanged);
            // 
            // panelAgregarDatos
            // 
            this.panelAgregarDatos.Controls.Add(this.bttnAgregar);
            this.panelAgregarDatos.Controls.Add(this.lblAgregarColor);
            this.panelAgregarDatos.Controls.Add(this.txtBoxColor);
            this.panelAgregarDatos.Controls.Add(this.lblAgregarKm);
            this.panelAgregarDatos.Controls.Add(this.numKm);
            this.panelAgregarDatos.Controls.Add(this.lblAgregarAnio);
            this.panelAgregarDatos.Controls.Add(this.numAnio);
            this.panelAgregarDatos.Controls.Add(this.lblAgregarDuenio);
            this.panelAgregarDatos.Controls.Add(this.txtBoxDuenio);
            this.panelAgregarDatos.Location = new System.Drawing.Point(18, 121);
            this.panelAgregarDatos.Name = "panelAgregarDatos";
            this.panelAgregarDatos.Size = new System.Drawing.Size(216, 133);
            this.panelAgregarDatos.TabIndex = 6;
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.Location = new System.Drawing.Point(69, 107);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(75, 23);
            this.bttnAgregar.TabIndex = 13;
            this.bttnAgregar.Text = "Dar de alta";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // lblAgregarColor
            // 
            this.lblAgregarColor.AutoSize = true;
            this.lblAgregarColor.Location = new System.Drawing.Point(6, 84);
            this.lblAgregarColor.Name = "lblAgregarColor";
            this.lblAgregarColor.Size = new System.Drawing.Size(31, 13);
            this.lblAgregarColor.TabIndex = 12;
            this.lblAgregarColor.Text = "Color";
            // 
            // txtBoxColor
            // 
            this.txtBoxColor.Location = new System.Drawing.Point(69, 81);
            this.txtBoxColor.Name = "txtBoxColor";
            this.txtBoxColor.Size = new System.Drawing.Size(127, 20);
            this.txtBoxColor.TabIndex = 11;
            // 
            // lblAgregarKm
            // 
            this.lblAgregarKm.AutoSize = true;
            this.lblAgregarKm.Location = new System.Drawing.Point(6, 57);
            this.lblAgregarKm.Name = "lblAgregarKm";
            this.lblAgregarKm.Size = new System.Drawing.Size(22, 13);
            this.lblAgregarKm.TabIndex = 10;
            this.lblAgregarKm.Text = "Km";
            // 
            // numKm
            // 
            this.numKm.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numKm.Location = new System.Drawing.Point(69, 55);
            this.numKm.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numKm.Name = "numKm";
            this.numKm.Size = new System.Drawing.Size(127, 20);
            this.numKm.TabIndex = 9;
            // 
            // lblAgregarAnio
            // 
            this.lblAgregarAnio.AutoSize = true;
            this.lblAgregarAnio.Location = new System.Drawing.Point(6, 31);
            this.lblAgregarAnio.Name = "lblAgregarAnio";
            this.lblAgregarAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAgregarAnio.TabIndex = 8;
            this.lblAgregarAnio.Text = "Año";
            // 
            // numAnio
            // 
            this.numAnio.Location = new System.Drawing.Point(69, 29);
            this.numAnio.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numAnio.Minimum = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            this.numAnio.Name = "numAnio";
            this.numAnio.Size = new System.Drawing.Size(127, 20);
            this.numAnio.TabIndex = 7;
            this.numAnio.Value = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            // 
            // lblAgregarDuenio
            // 
            this.lblAgregarDuenio.AutoSize = true;
            this.lblAgregarDuenio.Location = new System.Drawing.Point(6, 6);
            this.lblAgregarDuenio.Name = "lblAgregarDuenio";
            this.lblAgregarDuenio.Size = new System.Drawing.Size(39, 13);
            this.lblAgregarDuenio.TabIndex = 1;
            this.lblAgregarDuenio.Text = "Dueño";
            // 
            // txtBoxDuenio
            // 
            this.txtBoxDuenio.Location = new System.Drawing.Point(69, 3);
            this.txtBoxDuenio.Name = "txtBoxDuenio";
            this.txtBoxDuenio.Size = new System.Drawing.Size(127, 20);
            this.txtBoxDuenio.TabIndex = 0;
            // 
            // lblAgregarAlerta
            // 
            this.lblAgregarAlerta.AutoSize = true;
            this.lblAgregarAlerta.BackColor = System.Drawing.SystemColors.Control;
            this.lblAgregarAlerta.ForeColor = System.Drawing.Color.Red;
            this.lblAgregarAlerta.Location = new System.Drawing.Point(9, 254);
            this.lblAgregarAlerta.Name = "lblAgregarAlerta";
            this.lblAgregarAlerta.Size = new System.Drawing.Size(131, 13);
            this.lblAgregarAlerta.TabIndex = 14;
            this.lblAgregarAlerta.Text = "Rellene todos los campos!";
            // 
            // panelAgregarModelo
            // 
            this.panelAgregarModelo.Controls.Add(this.lblAgregarModelo);
            this.panelAgregarModelo.Controls.Add(this.comboBoxAgregar2);
            this.panelAgregarModelo.Location = new System.Drawing.Point(18, 71);
            this.panelAgregarModelo.Name = "panelAgregarModelo";
            this.panelAgregarModelo.Size = new System.Drawing.Size(216, 44);
            this.panelAgregarModelo.TabIndex = 5;
            // 
            // lblAgregarModelo
            // 
            this.lblAgregarModelo.AutoSize = true;
            this.lblAgregarModelo.Location = new System.Drawing.Point(6, 0);
            this.lblAgregarModelo.Name = "lblAgregarModelo";
            this.lblAgregarModelo.Size = new System.Drawing.Size(42, 13);
            this.lblAgregarModelo.TabIndex = 6;
            this.lblAgregarModelo.Text = "Modelo";
            // 
            // comboBoxAgregar2
            // 
            this.comboBoxAgregar2.FormattingEnabled = true;
            this.comboBoxAgregar2.Location = new System.Drawing.Point(9, 16);
            this.comboBoxAgregar2.Name = "comboBoxAgregar2";
            this.comboBoxAgregar2.Size = new System.Drawing.Size(155, 21);
            this.comboBoxAgregar2.TabIndex = 7;
            this.comboBoxAgregar2.Text = "- Seleccione una opcion -";
            this.comboBoxAgregar2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgregar2_SelectedIndexChanged);
            // 
            // dataGridVehiculos
            // 
            this.dataGridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVehiculos.Location = new System.Drawing.Point(12, 296);
            this.dataGridVehiculos.Name = "dataGridVehiculos";
            this.dataGridVehiculos.Size = new System.Drawing.Size(470, 150);
            this.dataGridVehiculos.TabIndex = 1;
            // 
            // GBoxGenerar
            // 
            this.GBoxGenerar.Controls.Add(this.bttnGenerarSpacex);
            this.GBoxGenerar.Controls.Add(this.bttnGenerarTesla);
            this.GBoxGenerar.Location = new System.Drawing.Point(254, 9);
            this.GBoxGenerar.Name = "GBoxGenerar";
            this.GBoxGenerar.Size = new System.Drawing.Size(228, 52);
            this.GBoxGenerar.TabIndex = 7;
            this.GBoxGenerar.TabStop = false;
            this.GBoxGenerar.Text = "Generar Datos";
            // 
            // bttnGenerarSpacex
            // 
            this.bttnGenerarSpacex.Location = new System.Drawing.Point(122, 19);
            this.bttnGenerarSpacex.Name = "bttnGenerarSpacex";
            this.bttnGenerarSpacex.Size = new System.Drawing.Size(100, 23);
            this.bttnGenerarSpacex.TabIndex = 1;
            this.bttnGenerarSpacex.Text = "SpaceX";
            this.bttnGenerarSpacex.UseVisualStyleBackColor = true;
            this.bttnGenerarSpacex.Click += new System.EventHandler(this.bttnGenerarSpacex_Click);
            // 
            // bttnGenerarTesla
            // 
            this.bttnGenerarTesla.Location = new System.Drawing.Point(6, 19);
            this.bttnGenerarTesla.Name = "bttnGenerarTesla";
            this.bttnGenerarTesla.Size = new System.Drawing.Size(100, 23);
            this.bttnGenerarTesla.TabIndex = 0;
            this.bttnGenerarTesla.Text = "Tesla";
            this.bttnGenerarTesla.UseVisualStyleBackColor = true;
            this.bttnGenerarTesla.Click += new System.EventHandler(this.bttnGenerarTesla_Click);
            // 
            // lblGridTitulo
            // 
            this.lblGridTitulo.AutoSize = true;
            this.lblGridTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridTitulo.Location = new System.Drawing.Point(7, 267);
            this.lblGridTitulo.Name = "lblGridTitulo";
            this.lblGridTitulo.Size = new System.Drawing.Size(134, 25);
            this.lblGridTitulo.TabIndex = 8;
            this.lblGridTitulo.Text = "Lista de Tesla";
            // 
            // bttnCambiarLista
            // 
            this.bttnCambiarLista.Location = new System.Drawing.Point(354, 449);
            this.bttnCambiarLista.Name = "bttnCambiarLista";
            this.bttnCambiarLista.Size = new System.Drawing.Size(128, 23);
            this.bttnCambiarLista.TabIndex = 9;
            this.bttnCambiarLista.Text = "Ver lista SpaceX";
            this.bttnCambiarLista.UseVisualStyleBackColor = true;
            this.bttnCambiarLista.Click += new System.EventHandler(this.bttnCambiarLista_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.Location = new System.Drawing.Point(273, 449);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(75, 23);
            this.bttnEliminar.TabIndex = 10;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // dataGridTeslaKm
            // 
            this.dataGridTeslaKm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeslaKm.Location = new System.Drawing.Point(12, 498);
            this.dataGridTeslaKm.Name = "dataGridTeslaKm";
            this.dataGridTeslaKm.Size = new System.Drawing.Size(470, 25);
            this.dataGridTeslaKm.TabIndex = 11;
            // 
            // lblTeslaKm
            // 
            this.lblTeslaKm.AutoSize = true;
            this.lblTeslaKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeslaKm.Location = new System.Drawing.Point(7, 470);
            this.lblTeslaKm.Name = "lblTeslaKm";
            this.lblTeslaKm.Size = new System.Drawing.Size(175, 25);
            this.lblTeslaKm.TabIndex = 12;
            this.lblTeslaKm.Text = "Tesla con mas Km";
            // 
            // lblEliminarAlerta
            // 
            this.lblEliminarAlerta.AutoSize = true;
            this.lblEliminarAlerta.ForeColor = System.Drawing.Color.Red;
            this.lblEliminarAlerta.Location = new System.Drawing.Point(9, 449);
            this.lblEliminarAlerta.Name = "lblEliminarAlerta";
            this.lblEliminarAlerta.Size = new System.Drawing.Size(125, 13);
            this.lblEliminarAlerta.TabIndex = 13;
            this.lblEliminarAlerta.Text = "Seleccione mínimo 1 fila!";
            // 
            // bttnScan
            // 
            this.bttnScan.Location = new System.Drawing.Point(407, 270);
            this.bttnScan.Name = "bttnScan";
            this.bttnScan.Size = new System.Drawing.Size(75, 23);
            this.bttnScan.TabIndex = 14;
            this.bttnScan.Text = "Escanear";
            this.bttnScan.UseVisualStyleBackColor = true;
            this.bttnScan.Click += new System.EventHandler(this.bttnScan_Click);
            // 
            // GBoxScan
            // 
            this.GBoxScan.Controls.Add(this.LogoImage);
            this.GBoxScan.Controls.Add(this.dataGridService);
            this.GBoxScan.Controls.Add(this.lblService);
            this.GBoxScan.Controls.Add(this.lblAsientos);
            this.GBoxScan.Controls.Add(this.lblAutonomia);
            this.GBoxScan.Controls.Add(this.lblModel);
            this.GBoxScan.Location = new System.Drawing.Point(254, 71);
            this.GBoxScan.Name = "GBoxScan";
            this.GBoxScan.Size = new System.Drawing.Size(228, 187);
            this.GBoxScan.TabIndex = 15;
            this.GBoxScan.TabStop = false;
            this.GBoxScan.Text = "Vehículo Escaneado";
            // 
            // LogoImage
            // 
            this.LogoImage.Image = global::Proyecto2.Properties.Resources.Signo_Pregunta;
            this.LogoImage.Location = new System.Drawing.Point(153, 16);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(50, 50);
            this.LogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImage.TabIndex = 2;
            this.LogoImage.TabStop = false;
            // 
            // dataGridService
            // 
            this.dataGridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridService.Location = new System.Drawing.Point(6, 74);
            this.dataGridService.Name = "dataGridService";
            this.dataGridService.RowHeadersVisible = false;
            this.dataGridService.Size = new System.Drawing.Size(216, 106);
            this.dataGridService.TabIndex = 1;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(28, 42);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(67, 13);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Service: ???";
            // 
            // lblAsientos
            // 
            this.lblAsientos.AutoSize = true;
            this.lblAsientos.Location = new System.Drawing.Point(28, 55);
            this.lblAsientos.Name = "lblAsientos";
            this.lblAsientos.Size = new System.Drawing.Size(71, 13);
            this.lblAsientos.TabIndex = 0;
            this.lblAsientos.Text = "Asientos: ???";
            // 
            // lblAutonomia
            // 
            this.lblAutonomia.AutoSize = true;
            this.lblAutonomia.Location = new System.Drawing.Point(28, 29);
            this.lblAutonomia.Name = "lblAutonomia";
            this.lblAutonomia.Size = new System.Drawing.Size(81, 13);
            this.lblAutonomia.TabIndex = 0;
            this.lblAutonomia.Text = "Autonomia: ???";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(16, 16);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(66, 13);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Modelo: ???";
            // 
            // lblScanAlerta
            // 
            this.lblScanAlerta.AutoSize = true;
            this.lblScanAlerta.ForeColor = System.Drawing.Color.Red;
            this.lblScanAlerta.Location = new System.Drawing.Point(251, 254);
            this.lblScanAlerta.Name = "lblScanAlerta";
            this.lblScanAlerta.Size = new System.Drawing.Size(35, 13);
            this.lblScanAlerta.TabIndex = 16;
            this.lblScanAlerta.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(494, 531);
            this.Controls.Add(this.lblScanAlerta);
            this.Controls.Add(this.GBoxScan);
            this.Controls.Add(this.lblAgregarAlerta);
            this.Controls.Add(this.bttnScan);
            this.Controls.Add(this.lblEliminarAlerta);
            this.Controls.Add(this.lblTeslaKm);
            this.Controls.Add(this.dataGridTeslaKm);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnCambiarLista);
            this.Controls.Add(this.lblGridTitulo);
            this.Controls.Add(this.GBoxGenerar);
            this.Controls.Add(this.panelAgregarDatos);
            this.Controls.Add(this.dataGridVehiculos);
            this.Controls.Add(this.panelAgregarModelo);
            this.Controls.Add(this.GBoxAgregar);
            this.Name = "Form1";
            this.Text = "Sistema de Gestion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBoxAgregar.ResumeLayout(false);
            this.GBoxAgregar.PerformLayout();
            this.panelAgregarDatos.ResumeLayout(false);
            this.panelAgregarDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).EndInit();
            this.panelAgregarModelo.ResumeLayout(false);
            this.panelAgregarModelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehiculos)).EndInit();
            this.GBoxGenerar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeslaKm)).EndInit();
            this.GBoxScan.ResumeLayout(false);
            this.GBoxScan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBoxAgregar;
        private System.Windows.Forms.Label lblAgregarTipovehiculo;
        private System.Windows.Forms.ComboBox comboBoxAgregar1;
        private System.Windows.Forms.DataGridView dataGridVehiculos;
        private System.Windows.Forms.Panel panelAgregarModelo;
        private System.Windows.Forms.Label lblAgregarModelo;
        private System.Windows.Forms.ComboBox comboBoxAgregar2;
        private System.Windows.Forms.Panel panelAgregarDatos;
        private System.Windows.Forms.Label lblAgregarDuenio;
        private System.Windows.Forms.TextBox txtBoxDuenio;
        private System.Windows.Forms.Label lblAgregarAnio;
        private System.Windows.Forms.NumericUpDown numAnio;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.Label lblAgregarColor;
        private System.Windows.Forms.TextBox txtBoxColor;
        private System.Windows.Forms.Label lblAgregarKm;
        private System.Windows.Forms.NumericUpDown numKm;
        private System.Windows.Forms.Label lblAgregarAlerta;
        private System.Windows.Forms.GroupBox GBoxGenerar;
        private System.Windows.Forms.Button bttnGenerarSpacex;
        private System.Windows.Forms.Button bttnGenerarTesla;
        private System.Windows.Forms.Label lblGridTitulo;
        private System.Windows.Forms.Button bttnCambiarLista;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.DataGridView dataGridTeslaKm;
        private System.Windows.Forms.Label lblTeslaKm;
        private System.Windows.Forms.Label lblEliminarAlerta;
        private System.Windows.Forms.Button bttnScan;
        private System.Windows.Forms.GroupBox GBoxScan;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblAsientos;
        private System.Windows.Forms.Label lblAutonomia;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.DataGridView dataGridService;
        private System.Windows.Forms.Label lblScanAlerta;
        private System.Windows.Forms.PictureBox LogoImage;
    }
}

