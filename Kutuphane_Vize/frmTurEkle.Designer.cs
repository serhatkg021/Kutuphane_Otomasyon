namespace Kutuphane_Vize
{
    partial class frmTurEkle
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
            this.btnTurEkle = new System.Windows.Forms.Button();
            this.tbTurAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTurEkle
            // 
            this.btnTurEkle.Location = new System.Drawing.Point(101, 93);
            this.btnTurEkle.Name = "btnTurEkle";
            this.btnTurEkle.Size = new System.Drawing.Size(138, 23);
            this.btnTurEkle.TabIndex = 7;
            this.btnTurEkle.Text = "Ekle";
            this.btnTurEkle.UseVisualStyleBackColor = true;
            this.btnTurEkle.Click += new System.EventHandler(this.btnTurEkle_Click);
            // 
            // tbTurAd
            // 
            this.tbTurAd.Location = new System.Drawing.Point(101, 55);
            this.tbTurAd.Name = "tbTurAd";
            this.tbTurAd.Size = new System.Drawing.Size(138, 20);
            this.tbTurAd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tür :";
            // 
            // frmTurEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 171);
            this.Controls.Add(this.btnTurEkle);
            this.Controls.Add(this.tbTurAd);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTurEkle";
            this.Text = "Tür Ekle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTurEkle_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTurEkle;
        private System.Windows.Forms.TextBox tbTurAd;
        private System.Windows.Forms.Label label2;
    }
}