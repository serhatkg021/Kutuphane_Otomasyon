namespace Kutuphane_Vize
{
    partial class frmDilEkle
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
            this.btnDilEkle = new System.Windows.Forms.Button();
            this.tbDilAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDilEkle
            // 
            this.btnDilEkle.Location = new System.Drawing.Point(113, 93);
            this.btnDilEkle.Name = "btnDilEkle";
            this.btnDilEkle.Size = new System.Drawing.Size(138, 23);
            this.btnDilEkle.TabIndex = 10;
            this.btnDilEkle.Text = "Ekle";
            this.btnDilEkle.UseVisualStyleBackColor = true;
            this.btnDilEkle.Click += new System.EventHandler(this.btnDilEkle_Click);
            // 
            // tbDilAd
            // 
            this.tbDilAd.Location = new System.Drawing.Point(113, 55);
            this.tbDilAd.Name = "tbDilAd";
            this.tbDilAd.Size = new System.Drawing.Size(138, 20);
            this.tbDilAd.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dil :";
            // 
            // frmDilEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 171);
            this.Controls.Add(this.btnDilEkle);
            this.Controls.Add(this.tbDilAd);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDilEkle";
            this.Text = "frmDilEkle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDilEkle_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDilEkle;
        private System.Windows.Forms.TextBox tbDilAd;
        private System.Windows.Forms.Label label2;
    }
}