namespace SistemaDeVentas
{
    partial class FPagar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbPagar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPagaCon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbVuelto = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL A PAGAR";
            // 
            // lbPagar
            // 
            this.lbPagar.AutoSize = true;
            this.lbPagar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPagar.Location = new System.Drawing.Point(286, 294);
            this.lbPagar.Name = "lbPagar";
            this.lbPagar.Size = new System.Drawing.Size(17, 17);
            this.lbPagar.TabIndex = 1;
            this.lbPagar.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "PAGA CON";
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagaCon.Location = new System.Drawing.Point(142, 75);
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(120, 26);
            this.txtPagaCon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "VUELTO";
            // 
            // lbVuelto
            // 
            this.lbVuelto.AutoSize = true;
            this.lbVuelto.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVuelto.Location = new System.Drawing.Point(150, 156);
            this.lbVuelto.Name = "lbVuelto";
            this.lbVuelto.Size = new System.Drawing.Size(20, 21);
            this.lbVuelto.TabIndex = 5;
            this.lbVuelto.Text = "$";
            // 
            // btnPagar
            // 
            this.btnPagar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPagar.Location = new System.Drawing.Point(268, 76);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 6;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // FPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 331);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lbVuelto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPagaCon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPagar);
            this.Controls.Add(this.label1);
            this.Name = "FPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FPagar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPagar;
        public System.Windows.Forms.Label lbPagar;
        public System.Windows.Forms.TextBox txtPagaCon;
        public System.Windows.Forms.Label lbVuelto;
    }
}