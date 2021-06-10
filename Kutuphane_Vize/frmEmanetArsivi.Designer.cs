namespace Kutuphane_Vize
{
    partial class frmEmanetArsivi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEmanetArsiv = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnKayitAra = new System.Windows.Forms.Button();
            this.tbKayitAra = new System.Windows.Forms.TextBox();
            this.btnArsivListeYenile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanetArsiv)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEmanetArsiv);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 439);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet Arşiv";
            // 
            // dgvEmanetArsiv
            // 
            this.dgvEmanetArsiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmanetArsiv.Location = new System.Drawing.Point(7, 19);
            this.dgvEmanetArsiv.Name = "dgvEmanetArsiv";
            this.dgvEmanetArsiv.Size = new System.Drawing.Size(859, 414);
            this.dgvEmanetArsiv.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnArsivListeYenile);
            this.groupBox4.Controls.Add(this.btnKayitAra);
            this.groupBox4.Controls.Add(this.tbKayitAra);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(872, 100);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kayıt Arama";
            // 
            // btnKayitAra
            // 
            this.btnKayitAra.Location = new System.Drawing.Point(17, 57);
            this.btnKayitAra.Name = "btnKayitAra";
            this.btnKayitAra.Size = new System.Drawing.Size(653, 23);
            this.btnKayitAra.TabIndex = 1;
            this.btnKayitAra.Text = "Ara";
            this.btnKayitAra.UseVisualStyleBackColor = true;
            this.btnKayitAra.Click += new System.EventHandler(this.btnKayitAra_Click);
            // 
            // tbKayitAra
            // 
            this.tbKayitAra.Location = new System.Drawing.Point(17, 29);
            this.tbKayitAra.Name = "tbKayitAra";
            this.tbKayitAra.Size = new System.Drawing.Size(839, 20);
            this.tbKayitAra.TabIndex = 0;
            // 
            // btnArsivListeYenile
            // 
            this.btnArsivListeYenile.Location = new System.Drawing.Point(676, 56);
            this.btnArsivListeYenile.Name = "btnArsivListeYenile";
            this.btnArsivListeYenile.Size = new System.Drawing.Size(180, 23);
            this.btnArsivListeYenile.TabIndex = 2;
            this.btnArsivListeYenile.Text = "Liste Yenile";
            this.btnArsivListeYenile.UseVisualStyleBackColor = true;
            this.btnArsivListeYenile.Click += new System.EventHandler(this.btnArsivListeYenile_Click);
            // 
            // frmEmanetArsivi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 565);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEmanetArsivi";
            this.Text = "Emanet Arşivi";
            this.Load += new System.EventHandler(this.frmEmanetArsivi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanetArsiv)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEmanetArsiv;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnKayitAra;
        private System.Windows.Forms.TextBox tbKayitAra;
        private System.Windows.Forms.Button btnArsivListeYenile;
    }
}