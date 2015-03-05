namespace Zapateria
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;//componente que no tiene mas ventanas de las que se estan trabajando

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)//para cerrar ventana
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoYDescuentosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infromesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAgregarAlcarro = new System.Windows.Forms.Button();
            this.textBoxBusquedaProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewVistaPreviaProducto = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCarroCompra = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDescuento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTipoCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxBusquedaCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonCancelarCompra = new System.Windows.Forms.Button();
            this.buttonVender = new System.Windows.Forms.Button();
            this.buttonFinalizarCompra = new System.Windows.Forms.Button();
            this.groupBoxFinalizarCompra = new System.Windows.Forms.GroupBox();
            this.buttonNuevaVenta = new System.Windows.Forms.Button();
            this.textBoxVuelto = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxPagaCon = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxTotalPago = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxTipoClienteCompra = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxTotalArticulos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxSubtotalCompra = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxIVA = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxNetoCompra = new System.Windows.Forms.TextBox();
            this.textBoxDecuentoCompra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerfechaVenta = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVistaPreviaProducto)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarroCompra)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxFinalizarCompra.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.edicionToolStripMenuItem,
            this.resumenVentasToolStripMenuItem,
            this.infromesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1090, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapatoToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.edicionToolStripMenuItem.Text = "Edicion";
            this.edicionToolStripMenuItem.Click += new System.EventHandler(this.edicionToolStripMenuItem_Click);
            // 
            // zapatoToolStripMenuItem
            // 
            this.zapatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.registrarTipoToolStripMenuItem});
            this.zapatoToolStripMenuItem.Name = "zapatoToolStripMenuItem";
            this.zapatoToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.zapatoToolStripMenuItem.Text = "Zapato";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // registrarTipoToolStripMenuItem
            // 
            this.registrarTipoToolStripMenuItem.Name = "registrarTipoToolStripMenuItem";
            this.registrarTipoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.registrarTipoToolStripMenuItem.Text = "Registrar Tipo";
            this.registrarTipoToolStripMenuItem.Click += new System.EventHandler(this.registrarTipoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem1,
            this.editarToolStripMenuItem1,
            this.listarToolStripMenuItem1,
            this.buscarToolStripMenuItem1,
            this.tipoYDescuentosClientesToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.nuevoToolStripMenuItem1.Text = "Nuevo";
            this.nuevoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoToolStripMenuItem1_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.editarToolStripMenuItem1.Text = "Editar";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.editarToolStripMenuItem1_Click);
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // buscarToolStripMenuItem1
            // 
            this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.buscarToolStripMenuItem1.Text = "Buscar";
            this.buscarToolStripMenuItem1.Click += new System.EventHandler(this.buscarToolStripMenuItem1_Click);
            // 
            // tipoYDescuentosClientesToolStripMenuItem
            // 
            this.tipoYDescuentosClientesToolStripMenuItem.Name = "tipoYDescuentosClientesToolStripMenuItem";
            this.tipoYDescuentosClientesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.tipoYDescuentosClientesToolStripMenuItem.Text = "Tipo y Descuentos Clientes";
            this.tipoYDescuentosClientesToolStripMenuItem.Click += new System.EventHandler(this.tipoYDescuentosClientesToolStripMenuItem_Click);
            // 
            // resumenVentasToolStripMenuItem
            // 
            this.resumenVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoVentasToolStripMenuItem});
            this.resumenVentasToolStripMenuItem.Name = "resumenVentasToolStripMenuItem";
            this.resumenVentasToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.resumenVentasToolStripMenuItem.Text = "Ventas";
            // 
            // listadoVentasToolStripMenuItem
            // 
            this.listadoVentasToolStripMenuItem.Name = "listadoVentasToolStripMenuItem";
            this.listadoVentasToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.listadoVentasToolStripMenuItem.Text = "Buscar Venta";
            this.listadoVentasToolStripMenuItem.Click += new System.EventHandler(this.listadoVentasToolStripMenuItem_Click);
            // 
            // infromesToolStripMenuItem
            // 
            this.infromesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resumenVentaToolStripMenuItem});
            this.infromesToolStripMenuItem.Name = "infromesToolStripMenuItem";
            this.infromesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.infromesToolStripMenuItem.Text = "Informes";
            // 
            // resumenVentaToolStripMenuItem
            // 
            this.resumenVentaToolStripMenuItem.Name = "resumenVentaToolStripMenuItem";
            this.resumenVentaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.resumenVentaToolStripMenuItem.Text = "Resumen venta mensual";
            this.resumenVentaToolStripMenuItem.Click += new System.EventHandler(this.resumenVentaToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAgregarAlcarro);
            this.groupBox1.Controls.Add(this.textBoxBusquedaProducto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(357, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar productos al carro";
            // 
            // buttonAgregarAlcarro
            // 
            this.buttonAgregarAlcarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregarAlcarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarAlcarro.Location = new System.Drawing.Point(264, 23);
            this.buttonAgregarAlcarro.Name = "buttonAgregarAlcarro";
            this.buttonAgregarAlcarro.Size = new System.Drawing.Size(97, 28);
            this.buttonAgregarAlcarro.TabIndex = 4;
            this.buttonAgregarAlcarro.Text = "Agregar al carro";
            this.buttonAgregarAlcarro.UseVisualStyleBackColor = true;
            this.buttonAgregarAlcarro.Click += new System.EventHandler(this.buttonAgregarAlcarro_Click);
            // 
            // textBoxBusquedaProducto
            // 
            this.textBoxBusquedaProducto.Location = new System.Drawing.Point(130, 28);
            this.textBoxBusquedaProducto.Name = "textBoxBusquedaProducto";
            this.textBoxBusquedaProducto.Size = new System.Drawing.Size(107, 20);
            this.textBoxBusquedaProducto.TabIndex = 2;
            this.textBoxBusquedaProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBusquedaProducto_MouseClick);
            this.textBoxBusquedaProducto.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Codigo del Producto :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewVistaPreviaProducto);
            this.groupBox2.Location = new System.Drawing.Point(357, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 87);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vista Previa Productos";
            // 
            // dataGridViewVistaPreviaProducto
            // 
            this.dataGridViewVistaPreviaProducto.AllowUserToAddRows = false;
            this.dataGridViewVistaPreviaProducto.AllowUserToDeleteRows = false;
            this.dataGridViewVistaPreviaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVistaPreviaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewVistaPreviaProducto.Location = new System.Drawing.Point(10, 19);
            this.dataGridViewVistaPreviaProducto.Name = "dataGridViewVistaPreviaProducto";
            this.dataGridViewVistaPreviaProducto.ReadOnly = true;
            this.dataGridViewVistaPreviaProducto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewVistaPreviaProducto.Size = new System.Drawing.Size(700, 55);
            this.dataGridViewVistaPreviaProducto.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Marca";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Numero";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tipo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Stock";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewCarroCompra);
            this.groupBox3.Location = new System.Drawing.Point(357, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(722, 188);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Carro de Compras";
            // 
            // dataGridViewCarroCompra
            // 
            this.dataGridViewCarroCompra.AllowUserToAddRows = false;
            this.dataGridViewCarroCompra.AllowUserToDeleteRows = false;
            this.dataGridViewCarroCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarroCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.dataGridViewTextBoxColumn2,
            this.Column12,
            this.Column10,
            this.dataGridViewTextBoxColumn4,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridViewCarroCompra.Location = new System.Drawing.Point(10, 19);
            this.dataGridViewCarroCompra.Name = "dataGridViewCarroCompra";
            this.dataGridViewCarroCompra.ReadOnly = true;
            this.dataGridViewCarroCompra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewCarroCompra.Size = new System.Drawing.Size(700, 163);
            this.dataGridViewCarroCompra.TabIndex = 2;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Codigo Producto";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 102;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Número Calzado";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Cantidad";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Subtotal Producto";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "IVA";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Neto";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 70;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(12, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 352);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del Cliente";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.textBoxDescuento);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.textBoxTipoCliente);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.textBoxEmail);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.textBoxDireccion);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.textBoxFono);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.textBoxApellidos);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.textBoxNombres);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.textBoxRun);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Location = new System.Drawing.Point(6, 96);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(327, 250);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "%";
            // 
            // textBoxDescuento
            // 
            this.textBoxDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescuento.Enabled = false;
            this.textBoxDescuento.Location = new System.Drawing.Point(96, 211);
            this.textBoxDescuento.Name = "textBoxDescuento";
            this.textBoxDescuento.Size = new System.Drawing.Size(78, 20);
            this.textBoxDescuento.TabIndex = 15;
            this.textBoxDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Descuento :";
            // 
            // textBoxTipoCliente
            // 
            this.textBoxTipoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTipoCliente.Enabled = false;
            this.textBoxTipoCliente.Location = new System.Drawing.Point(96, 185);
            this.textBoxTipoCliente.Name = "textBoxTipoCliente";
            this.textBoxTipoCliente.Size = new System.Drawing.Size(171, 20);
            this.textBoxTipoCliente.TabIndex = 13;
            this.textBoxTipoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tipo Cliente :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Location = new System.Drawing.Point(96, 159);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(171, 20);
            this.textBoxEmail.TabIndex = 11;
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email :";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDireccion.Enabled = false;
            this.textBoxDireccion.Location = new System.Drawing.Point(96, 133);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(171, 20);
            this.textBoxDireccion.TabIndex = 9;
            this.textBoxDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dirección :";
            // 
            // textBoxFono
            // 
            this.textBoxFono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFono.Enabled = false;
            this.textBoxFono.Location = new System.Drawing.Point(96, 107);
            this.textBoxFono.Name = "textBoxFono";
            this.textBoxFono.Size = new System.Drawing.Size(171, 20);
            this.textBoxFono.TabIndex = 7;
            this.textBoxFono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fono :";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxApellidos.Enabled = false;
            this.textBoxApellidos.Location = new System.Drawing.Point(96, 81);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(171, 20);
            this.textBoxApellidos.TabIndex = 5;
            this.textBoxApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellidos :";
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombres.Enabled = false;
            this.textBoxNombres.Location = new System.Drawing.Point(96, 55);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(171, 20);
            this.textBoxNombres.TabIndex = 3;
            this.textBoxNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres :";
            // 
            // textBoxRun
            // 
            this.textBoxRun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRun.Enabled = false;
            this.textBoxRun.Location = new System.Drawing.Point(96, 29);
            this.textBoxRun.Name = "textBoxRun";
            this.textBoxRun.Size = new System.Drawing.Size(171, 20);
            this.textBoxRun.TabIndex = 1;
            this.textBoxRun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Run :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxBusquedaCliente);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(6, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(327, 71);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Buscar Cliente";
            // 
            // textBoxBusquedaCliente
            // 
            this.textBoxBusquedaCliente.Location = new System.Drawing.Point(96, 26);
            this.textBoxBusquedaCliente.Name = "textBoxBusquedaCliente";
            this.textBoxBusquedaCliente.Size = new System.Drawing.Size(171, 20);
            this.textBoxBusquedaCliente.TabIndex = 1;
            this.textBoxBusquedaCliente.TextChanged += new System.EventHandler(this.textBoxBusquedaCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Run :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonCancelarCompra);
            this.groupBox5.Controls.Add(this.buttonVender);
            this.groupBox5.Controls.Add(this.buttonFinalizarCompra);
            this.groupBox5.Controls.Add(this.groupBoxFinalizarCompra);
            this.groupBox5.Location = new System.Drawing.Point(12, 385);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1066, 147);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Finalizar Compras";
            // 
            // buttonCancelarCompra
            // 
            this.buttonCancelarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarCompra.Location = new System.Drawing.Point(943, 13);
            this.buttonCancelarCompra.Name = "buttonCancelarCompra";
            this.buttonCancelarCompra.Size = new System.Drawing.Size(112, 41);
            this.buttonCancelarCompra.TabIndex = 22;
            this.buttonCancelarCompra.Text = "Cancelar Compra";
            this.buttonCancelarCompra.UseVisualStyleBackColor = true;
            this.buttonCancelarCompra.Click += new System.EventHandler(this.buttonCancelarCompra_Click);
            // 
            // buttonVender
            // 
            this.buttonVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVender.Location = new System.Drawing.Point(943, 57);
            this.buttonVender.Name = "buttonVender";
            this.buttonVender.Size = new System.Drawing.Size(112, 41);
            this.buttonVender.TabIndex = 21;
            this.buttonVender.Text = "Vender";
            this.buttonVender.UseVisualStyleBackColor = true;
            this.buttonVender.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFinalizarCompra
            // 
            this.buttonFinalizarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinalizarCompra.Location = new System.Drawing.Point(943, 100);
            this.buttonFinalizarCompra.Name = "buttonFinalizarCompra";
            this.buttonFinalizarCompra.Size = new System.Drawing.Size(112, 41);
            this.buttonFinalizarCompra.TabIndex = 20;
            this.buttonFinalizarCompra.Text = "Ver datos de la compra";
            this.buttonFinalizarCompra.UseVisualStyleBackColor = true;
            this.buttonFinalizarCompra.Click += new System.EventHandler(this.buttonFinalizarCompra_Click);
            // 
            // groupBoxFinalizarCompra
            // 
            this.groupBoxFinalizarCompra.Controls.Add(this.buttonNuevaVenta);
            this.groupBoxFinalizarCompra.Controls.Add(this.textBoxVuelto);
            this.groupBoxFinalizarCompra.Controls.Add(this.label22);
            this.groupBoxFinalizarCompra.Controls.Add(this.textBoxPagaCon);
            this.groupBoxFinalizarCompra.Controls.Add(this.label21);
            this.groupBoxFinalizarCompra.Controls.Add(this.textBoxTotalPago);
            this.groupBoxFinalizarCompra.Controls.Add(this.label20);
            this.groupBoxFinalizarCompra.Controls.Add(this.textBoxTipoClienteCompra);
            this.groupBoxFinalizarCompra.Controls.Add(this.label17);
            this.groupBoxFinalizarCompra.Controls.Add(this.textBoxTotalArticulos);
            this.groupBoxFinalizarCompra.Controls.Add(this.label12);
            this.groupBoxFinalizarCompra.Controls.Add(this.label19);
            this.groupBoxFinalizarCompra.Controls.Add(this.textBoxSubtotalCompra);
            this.groupBoxFinalizarCompra.Controls.Add(this.label18);
            this.groupBoxFinalizarCompra.Controls.Add(this.label13);
            this.groupBoxFinalizarCompra.Controls.Add(this.label16);
            this.groupBoxFinalizarCompra.Controls.Add(this.textBoxIVA);
            this.groupBoxFinalizarCompra.Controls.Add(this.label14);
            this.groupBoxFinalizarCompra.Controls.Add(this.textBoxNetoCompra);
            this.groupBoxFinalizarCompra.Controls.Add(this.textBoxDecuentoCompra);
            this.groupBoxFinalizarCompra.Controls.Add(this.label15);
            this.groupBoxFinalizarCompra.Location = new System.Drawing.Point(6, 14);
            this.groupBoxFinalizarCompra.Name = "groupBoxFinalizarCompra";
            this.groupBoxFinalizarCompra.Size = new System.Drawing.Size(931, 127);
            this.groupBoxFinalizarCompra.TabIndex = 3;
            this.groupBoxFinalizarCompra.TabStop = false;
            // 
            // buttonNuevaVenta
            // 
            this.buttonNuevaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevaVenta.Location = new System.Drawing.Point(789, 48);
            this.buttonNuevaVenta.Name = "buttonNuevaVenta";
            this.buttonNuevaVenta.Size = new System.Drawing.Size(112, 41);
            this.buttonNuevaVenta.TabIndex = 27;
            this.buttonNuevaVenta.Text = "Nueva Venta";
            this.buttonNuevaVenta.UseVisualStyleBackColor = true;
            this.buttonNuevaVenta.Click += new System.EventHandler(this.buttonNuevaVenta_Click);
            // 
            // textBoxVuelto
            // 
            this.textBoxVuelto.Enabled = false;
            this.textBoxVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVuelto.Location = new System.Drawing.Point(654, 89);
            this.textBoxVuelto.Name = "textBoxVuelto";
            this.textBoxVuelto.Size = new System.Drawing.Size(100, 26);
            this.textBoxVuelto.TabIndex = 26;
            this.textBoxVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(519, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 24);
            this.label22.TabIndex = 25;
            this.label22.Text = "Vuelto :";
            // 
            // textBoxPagaCon
            // 
            this.textBoxPagaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPagaCon.Location = new System.Drawing.Point(654, 59);
            this.textBoxPagaCon.Name = "textBoxPagaCon";
            this.textBoxPagaCon.Size = new System.Drawing.Size(100, 26);
            this.textBoxPagaCon.TabIndex = 3;
            this.textBoxPagaCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(519, 60);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 24);
            this.label21.TabIndex = 23;
            this.label21.Text = "Paga con :";
            // 
            // textBoxTotalPago
            // 
            this.textBoxTotalPago.Enabled = false;
            this.textBoxTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalPago.Location = new System.Drawing.Point(654, 29);
            this.textBoxTotalPago.Name = "textBoxTotalPago";
            this.textBoxTotalPago.Size = new System.Drawing.Size(100, 26);
            this.textBoxTotalPago.TabIndex = 22;
            this.textBoxTotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(519, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 24);
            this.label20.TabIndex = 21;
            this.label20.Text = "Total a pagar :";
            // 
            // textBoxTipoClienteCompra
            // 
            this.textBoxTipoClienteCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTipoClienteCompra.Enabled = false;
            this.textBoxTipoClienteCompra.Location = new System.Drawing.Point(381, 60);
            this.textBoxTipoClienteCompra.Name = "textBoxTipoClienteCompra";
            this.textBoxTipoClienteCompra.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipoClienteCompra.TabIndex = 20;
            this.textBoxTipoClienteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(244, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Tipo cliente :";
            // 
            // textBoxTotalArticulos
            // 
            this.textBoxTotalArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTotalArticulos.Enabled = false;
            this.textBoxTotalArticulos.Location = new System.Drawing.Point(381, 35);
            this.textBoxTotalArticulos.Name = "textBoxTotalArticulos";
            this.textBoxTotalArticulos.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalArticulos.TabIndex = 18;
            this.textBoxTotalArticulos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Subtotal de la compra :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(244, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Total Artículos a comprar : ";
            // 
            // textBoxSubtotalCompra
            // 
            this.textBoxSubtotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSubtotalCompra.Enabled = false;
            this.textBoxSubtotalCompra.Location = new System.Drawing.Point(133, 35);
            this.textBoxSubtotalCompra.Name = "textBoxSubtotalCompra";
            this.textBoxSubtotalCompra.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubtotalCompra.TabIndex = 1;
            this.textBoxSubtotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(423, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(91, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "I.V.A :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(214, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "%";
            // 
            // textBoxIVA
            // 
            this.textBoxIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIVA.Enabled = false;
            this.textBoxIVA.Location = new System.Drawing.Point(133, 61);
            this.textBoxIVA.Name = "textBoxIVA";
            this.textBoxIVA.Size = new System.Drawing.Size(75, 20);
            this.textBoxIVA.TabIndex = 3;
            this.textBoxIVA.Text = "19";
            this.textBoxIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Neto de la compra :";
            // 
            // textBoxNetoCompra
            // 
            this.textBoxNetoCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNetoCompra.Enabled = false;
            this.textBoxNetoCompra.Location = new System.Drawing.Point(133, 87);
            this.textBoxNetoCompra.Name = "textBoxNetoCompra";
            this.textBoxNetoCompra.Size = new System.Drawing.Size(100, 20);
            this.textBoxNetoCompra.TabIndex = 5;
            this.textBoxNetoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDecuentoCompra
            // 
            this.textBoxDecuentoCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDecuentoCompra.Enabled = false;
            this.textBoxDecuentoCompra.Location = new System.Drawing.Point(381, 87);
            this.textBoxDecuentoCompra.Name = "textBoxDecuentoCompra";
            this.textBoxDecuentoCompra.Size = new System.Drawing.Size(39, 20);
            this.textBoxDecuentoCompra.TabIndex = 7;
            this.textBoxDecuentoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(244, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Descuento por cliente :";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dateTimePickerfechaVenta);
            this.groupBox8.Location = new System.Drawing.Point(758, 27);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(320, 65);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Fecha Venta";
            // 
            // dateTimePickerfechaVenta
            // 
            this.dateTimePickerfechaVenta.Location = new System.Drawing.Point(59, 31);
            this.dateTimePickerfechaVenta.Name = "dateTimePickerfechaVenta";
            this.dateTimePickerfechaVenta.Size = new System.Drawing.Size(198, 20);
            this.dateTimePickerfechaVenta.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 544);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación Taller de Programación III - Zapateria";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVistaPreviaProducto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarroCompra)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBoxFinalizarCompra.ResumeLayout(false);
            this.groupBoxFinalizarCompra.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tipoYDescuentosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewVistaPreviaProducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewCarroCompra;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxTipoCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBusquedaCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescuento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBusquedaProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAgregarAlcarro;
        private System.Windows.Forms.ToolStripMenuItem resumenVentasToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.TextBox textBoxSubtotalCompra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxNetoCompra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxIVA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxDecuentoCompra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxTotalArticulos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBoxFinalizarCompra;
        private System.Windows.Forms.Button buttonFinalizarCompra;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxTipoClienteCompra;
        private System.Windows.Forms.TextBox textBoxVuelto;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxPagaCon;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxTotalPago;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button buttonCancelarCompra;
        private System.Windows.Forms.Button buttonVender;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DateTimePicker dateTimePickerfechaVenta;
        private System.Windows.Forms.Button buttonNuevaVenta;
        private System.Windows.Forms.ToolStripMenuItem listadoVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infromesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenVentaToolStripMenuItem;

    }
}

