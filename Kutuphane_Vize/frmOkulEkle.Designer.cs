namespace Kutuphane_Vize
{
    partial class frmOkulEkle
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
            this.tbOkulAd = new System.Windows.Forms.TextBox();
            this.btnOkulEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Okul Adı :";
            // 
            // tbOkulAd
            // 
            this.tbOkulAd.Location = new System.Drawing.Point(99, 37);
            this.tbOkulAd.Name = "tbOkulAd";
            this.tbOkulAd.Size = new System.Drawing.Size(239, 20);
            this.tbOkulAd.TabIndex = 1;
            // 
            // btnOkulEkle
            // 
            this.btnOkulEkle.Location = new System.Drawing.Point(99, 80);
            this.btnOkulEkle.Name = "btnOkulEkle";
            this.btnOkulEkle.Size = new System.Drawing.Size(239, 35);
            this.btnOkulEkle.TabIndex = 2;
            this.btnOkulEkle.Text = "Ekle";
            this.btnOkulEkle.UseVisualStyleBackColor = true;
            this.btnOkulEkle.Click += new System.EventHandler(this.btnOkulEkle_Click);
            // 
            // frmOkulEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 147);
            this.Controls.Add(this.btnOkulEkle);
            this.Controls.Add(this.tbOkulAd);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOkulEkle";
            this.Text = "frmOkulEkle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOkulEkle_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOkulAd;
        private System.Windows.Forms.Button btnOkulEkle;
    }
}