namespace SistemaDeVentas
{
    partial class FFotoProducto
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
            this.pbFotoGrande = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoGrande)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFotoGrande
            // 
            this.pbFotoGrande.Location = new System.Drawing.Point(12, 12);
            this.pbFotoGrande.Name = "pbFotoGrande";
            this.pbFotoGrande.Size = new System.Drawing.Size(400, 412);
            this.pbFotoGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoGrande.TabIndex = 0;
            this.pbFotoGrande.TabStop = false;
            // 
            // FFotoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 436);
            this.Controls.Add(this.pbFotoGrande);
            this.Name = "FFotoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foto del producto";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoGrande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pbFotoGrande;
    }
}