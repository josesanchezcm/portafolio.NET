namespace Zapateria.FormulariosCliente
{
    partial class FormRegistroTipoCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archvioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombreTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescuento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRegistrarTipo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewListarTipos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditarTipo = new System.Windows.Forms.Button();
            this.buttonEliminarTipo = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarAEdiciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarTipos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archvioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(401, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archvioToolStripMenuItem
            // 
            this.archvioToolStripMenuItem.Name = "archvioToolStripMenuItem";
            this.archvioToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archvioToolStripMenuItem.Text = "Archvio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewListarTipos);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro Tipos y Descuentos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo :";
            // 
            // textBoxNombreTipo
            // 
            this.textBoxNombreTipo.Location = new System.Drawing.Point(9, 41);
            this.textBoxNombreTipo.Name = "textBoxNombreTipo";
            this.textBoxNombreTipo.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreTipo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descuento Asociado:";
            // 
            // textBoxDescuento
            // 
            this.textBoxDescuento.Location = new System.Drawing.Point(115, 41);
            this.textBoxDescuento.Name = "textBoxDescuento";
            this.textBoxDescuento.Size = new System.Drawing.Size(120, 20);
            this.textBoxDescuento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "%";
            // 
            // buttonRegistrarTipo
            // 
            this.buttonRegistrarTipo.Location = new System.Drawing.Point(254, 92);
            this.buttonRegistrarTipo.Name = "buttonRegistrarTipo";
            this.buttonRegistrarTipo.Size = new System.Drawing.Size(83, 30);
            this.buttonRegistrarTipo.TabIndex = 5;
            this.buttonRegistrarTipo.Text = "Registrar";
            this.buttonRegistrarTipo.UseVisualStyleBackColor = true;
            this.buttonRegistrarTipo.Click += new System.EventHandler(this.buttonRegistrarTipo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCancelar);
            this.groupBox2.Controls.Add(this.buttonEliminarTipo);
            this.groupBox2.Controls.Add(this.buttonEditarTipo);
            this.groupBox2.Controls.Add(this.textBoxDescuento);
            this.groupBox2.Controls.Add(this.buttonRegistrarTipo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxNombreTipo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 128);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Nuevo";
            // 
            // dataGridViewListarTipos
            // 
            this.dataGridViewListarTipos.AllowUserToAddRows = false;
            this.dataGridViewListarTipos.AllowUserToDeleteRows = false;
            this.dataGridViewListarTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListarTipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewListarTipos.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewListarTipos.Location = new System.Drawing.Point(15, 167);
            this.dataGridViewListarTipos.Name = "dataGridViewListarTipos";
            this.dataGridViewListarTipos.ReadOnly = true;
            this.dataGridViewListarTipos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewListarTipos.Size = new System.Drawing.Size(343, 124);
            this.dataGridViewListarTipos.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tipo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descuento";
            this.Column3.Name = "Column3";
            // 
            // buttonEditarTipo
            // 
            this.buttonEditarTipo.Location = new System.Drawing.Point(254, 92);
            this.buttonEditarTipo.Name = "buttonEditarTipo";
            this.buttonEditarTipo.Size = new System.Drawing.Size(83, 30);
            this.buttonEditarTipo.TabIndex = 6;
            this.buttonEditarTipo.Text = "Editar";
            this.buttonEditarTipo.UseVisualStyleBackColor = true;
            this.buttonEditarTipo.Click += new System.EventHandler(this.buttonEditarTipo_Click);
            // 
            // buttonEliminarTipo
            // 
            this.buttonEliminarTipo.Location = new System.Drawing.Point(165, 92);
            this.buttonEliminarTipo.Name = "buttonEliminarTipo";
            this.buttonEliminarTipo.Size = new System.Drawing.Size(83, 30);
            this.buttonEliminarTipo.TabIndex = 7;
            this.buttonEliminarTipo.Text = "Eliminar";
            this.buttonEliminarTipo.UseVisualStyleBackColor = true;
            this.buttonEliminarTipo.Click += new System.EventHandler(this.buttonEliminarTipo_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAEdiciónToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 26);
            // 
            // agregarAEdiciónToolStripMenuItem
            // 
            this.agregarAEdiciónToolStripMenuItem.Name = "agregarAEdiciónToolStripMenuItem";
            this.agregarAEdiciónToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.agregarAEdiciónToolStripMenuItem.Text = "Agregar a Edición";
            this.agregarAEdiciónToolStripMenuItem.Click += new System.EventHandler(this.agregarAEdiciónToolStripMenuItem_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(76, 92);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(83, 30);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormRegistroTipoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 344);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormRegistroTipoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistroTipoCliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarTipos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archvioToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewListarTipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonEliminarTipo;
        private System.Windows.Forms.Button buttonEditarTipo;
        private System.Windows.Forms.TextBox textBoxDescuento;
        private System.Windows.Forms.Button buttonRegistrarTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombreTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarAEdiciónToolStripMenuItem;
        private System.Windows.Forms.Button buttonCancelar;
    }
}