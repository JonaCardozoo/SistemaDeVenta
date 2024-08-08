namespace SistemaDeVentas
{
    partial class FHistorialDeVentas
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
            this.lbHistorialDeVentas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbHistorialDeVentas
            // 
            this.lbHistorialDeVentas.FormattingEnabled = true;
            this.lbHistorialDeVentas.Location = new System.Drawing.Point(0, 0);
            this.lbHistorialDeVentas.Name = "lbHistorialDeVentas";
            this.lbHistorialDeVentas.Size = new System.Drawing.Size(757, 628);
            this.lbHistorialDeVentas.TabIndex = 0;
            // 
            // FHistorialDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 627);
            this.Controls.Add(this.lbHistorialDeVentas);
            this.Name = "FHistorialDeVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de ventas";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbHistorialDeVentas;
    }
}