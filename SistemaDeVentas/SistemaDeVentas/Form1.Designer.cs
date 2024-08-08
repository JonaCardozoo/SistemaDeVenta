namespace SistemaDeVentas
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
            this.components = new System.ComponentModel.Container();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.pbFotoProdu = new System.Windows.Forms.PictureBox();
            this.lbPedido = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbPrecioTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.TSAgregarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.TSModificarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.TSEliminarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hISTORIALDEVENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoProdu)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(13, 78);
            this.cbProductos.Margin = new System.Windows.Forms.Padding(4);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(396, 25);
            this.cbProductos.TabIndex = 0;
            this.cbProductos.Text = "Productos";
            this.cbProductos.SelectedIndexChanged += new System.EventHandler(this.cbProductos_SelectedIndexChanged);
            // 
            // pbFotoProdu
            // 
            this.pbFotoProdu.Location = new System.Drawing.Point(417, 75);
            this.pbFotoProdu.Margin = new System.Windows.Forms.Padding(4);
            this.pbFotoProdu.Name = "pbFotoProdu";
            this.pbFotoProdu.Size = new System.Drawing.Size(252, 184);
            this.pbFotoProdu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoProdu.TabIndex = 2;
            this.pbFotoProdu.TabStop = false;
            this.pbFotoProdu.Click += new System.EventHandler(this.pbFotoProdu_Click);
            this.pbFotoProdu.MouseHover += new System.EventHandler(this.pbFotoProdu_MouseHover);
            // 
            // lbPedido
            // 
            this.lbPedido.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedido.FormattingEnabled = true;
            this.lbPedido.ItemHeight = 34;
            this.lbPedido.Location = new System.Drawing.Point(36, 267);
            this.lbPedido.Margin = new System.Windows.Forms.Padding(4);
            this.lbPedido.Name = "lbPedido";
            this.lbPedido.Size = new System.Drawing.Size(633, 446);
            this.lbPedido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(113, 142);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(132, 26);
            this.txtCantidad.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(35, 199);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 60);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbPrecioTotal
            // 
            this.lbPrecioTotal.AutoSize = true;
            this.lbPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioTotal.Location = new System.Drawing.Point(677, 689);
            this.lbPrecioTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrecioTotal.Name = "lbPrecioTotal";
            this.lbPrecioTotal.Size = new System.Drawing.Size(39, 42);
            this.lbPrecioTotal.TabIndex = 7;
            this.lbPrecioTotal.Text = "$";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 77);
            this.button1.TabIndex = 8;
            this.button1.Text = "PAGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSInventario,
            this.TSAgregarProducto,
            this.TSModificarProducto,
            this.TSEliminarProducto,
            this.hISTORIALDEVENTASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1463, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSInventario
            // 
            this.TSInventario.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSInventario.Name = "TSInventario";
            this.TSInventario.Size = new System.Drawing.Size(96, 21);
            this.TSInventario.Text = "INVENTARIO";
            this.TSInventario.Click += new System.EventHandler(this.TSInventario_Click);
            // 
            // TSAgregarProducto
            // 
            this.TSAgregarProducto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSAgregarProducto.Name = "TSAgregarProducto";
            this.TSAgregarProducto.Size = new System.Drawing.Size(157, 21);
            this.TSAgregarProducto.Text = "AGREGAR PRODUCTO";
            this.TSAgregarProducto.Click += new System.EventHandler(this.TSAgregarProducto_Click);
            // 
            // TSModificarProducto
            // 
            this.TSModificarProducto.Name = "TSModificarProducto";
            this.TSModificarProducto.Size = new System.Drawing.Size(168, 21);
            this.TSModificarProducto.Text = "MODIFICAR PRODUCTO";
            this.TSModificarProducto.Click += new System.EventHandler(this.TSModificarProducto_Click);
            // 
            // TSEliminarProducto
            // 
            this.TSEliminarProducto.Name = "TSEliminarProducto";
            this.TSEliminarProducto.Size = new System.Drawing.Size(156, 21);
            this.TSEliminarProducto.Text = "ELIMINAR PRODUCTO";
            this.TSEliminarProducto.Click += new System.EventHandler(this.TSEliminarProducto_Click);
            // 
            // hISTORIALDEVENTASToolStripMenuItem
            // 
            this.hISTORIALDEVENTASToolStripMenuItem.Name = "hISTORIALDEVENTASToolStripMenuItem";
            this.hISTORIALDEVENTASToolStripMenuItem.Size = new System.Drawing.Size(161, 21);
            this.hISTORIALDEVENTASToolStripMenuItem.Text = "HISTORIAL DE VENTAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 758);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbPrecioTotal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPedido);
            this.Controls.Add(this.pbFotoProdu);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de ventas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoProdu)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.PictureBox pbFotoProdu;
        private System.Windows.Forms.ListBox lbPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbPrecioTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSInventario;
        private System.Windows.Forms.ToolStripMenuItem TSAgregarProducto;
        private System.Windows.Forms.ToolStripMenuItem TSModificarProducto;
        private System.Windows.Forms.ToolStripMenuItem TSEliminarProducto;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem hISTORIALDEVENTASToolStripMenuItem;
    }
}

