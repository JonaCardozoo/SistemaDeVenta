namespace SistemaDeVentas
{
    partial class FInventario
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
            this.dgInventario = new System.Windows.Forms.DataGridView();
            this.DGCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGFechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInventario
            // 
            this.dgInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGCodigo,
            this.DGNombre,
            this.DGPrecio,
            this.DGFechaCompra,
            this.DGCategoria,
            this.DGProveedor,
            this.DGEstado,
            this.DGStock});
            this.dgInventario.GridColor = System.Drawing.Color.Black;
            this.dgInventario.Location = new System.Drawing.Point(0, 1);
            this.dgInventario.Name = "dgInventario";
            this.dgInventario.Size = new System.Drawing.Size(844, 600);
            this.dgInventario.TabIndex = 0;
            // 
            // DGCodigo
            // 
            this.DGCodigo.HeaderText = "Codigo";
            this.DGCodigo.Name = "DGCodigo";
            // 
            // DGNombre
            // 
            this.DGNombre.HeaderText = "Nombre";
            this.DGNombre.Name = "DGNombre";
            // 
            // DGPrecio
            // 
            this.DGPrecio.HeaderText = "Precio";
            this.DGPrecio.Name = "DGPrecio";
            // 
            // DGFechaCompra
            // 
            this.DGFechaCompra.HeaderText = "Fecha de compra";
            this.DGFechaCompra.Name = "DGFechaCompra";
            // 
            // DGCategoria
            // 
            this.DGCategoria.HeaderText = "Categoria";
            this.DGCategoria.Name = "DGCategoria";
            // 
            // DGProveedor
            // 
            this.DGProveedor.HeaderText = "Proveedor";
            this.DGProveedor.Name = "DGProveedor";
            // 
            // DGEstado
            // 
            this.DGEstado.HeaderText = "Estado";
            this.DGEstado.Name = "DGEstado";
            // 
            // DGStock
            // 
            this.DGStock.HeaderText = "Stock";
            this.DGStock.Name = "DGStock";
            // 
            // FInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 603);
            this.Controls.Add(this.dgInventario);
            this.Name = "FInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGFechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGStock;
        public System.Windows.Forms.DataGridView dgInventario;
    }
}