namespace Kutuphane_Vize
{
    partial class frmYayineviEkle
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
            this.btnYayineviEkle = new System.Windows.Forms.Button();
            this.tbYayineviAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYayineviEkle
            // 
            this.btnYayineviEkle.Location = new System.Drawing.Point(113, 93);
            this.btnYayineviEkle.Name = "btnYayineviEkle";
            this.btnYayineviEkle.Size = new System.Drawing.Size(138, 23);
            this.btnYayineviEkle.TabIndex = 10;
            this.btnYayineviEkle.Text = "Ekle";
            this.btnYayineviEkle.UseVisualStyleBackColor = true;
            this.btnYayineviEkle.Click += new System.EventHandler(this.btnYayineviEkle_Click);
            // 
            // tbYayineviAd
            // 
            this.tbYayineviAd.Location = new System.Drawing.Point(113, 55);
            this.tbYayineviAd.Name = "tbYayineviAd";
            this.tbYayineviAd.Size = new System.Drawing.Size(138, 20);
            this.tbYayineviAd.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yayın Evi :";
            // 
            // frmYayineviEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 171);
            this.Controls.Add(this.btnYayineviEkle);
            this.Controls.Add(this.tbYayineviAd);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYayineviEkle";
            this.Text = "frmYayineviEkle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmYayineviEkle_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYayineviEkle;
        private System.Windows.Forms.TextBox tbYayineviAd;
        private System.Windows.Forms.Label label2;
    }
}