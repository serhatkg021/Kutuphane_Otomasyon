namespace Kutuphane_Vize
{
    partial class frmEmanetDuzenle
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
            this.gbKitapEkle = new System.Windows.Forms.GroupBox();
            this.lblEmanetNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEmanetKaydet = new System.Windows.Forms.Button();
            this.tbEmanetAciklama = new System.Windows.Forms.TextBox();
            this.cbEmanetTeslimDurum = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtEmanetTahminiTeslim = new System.Windows.Forms.DateTimePicker();
            this.gbKitapEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKitapEkle
            // 
            this.gbKitapEkle.Controls.Add(this.lblEmanetNo);
            this.gbKitapEkle.Controls.Add(this.label4);
            this.gbKitapEkle.Controls.Add(this.dtEmanetTahminiTeslim);
            this.gbKitapEkle.Controls.Add(this.label3);
            this.gbKitapEkle.Controls.Add(this.btnEmanetKaydet);
            this.gbKitapEkle.Controls.Add(this.tbEmanetAciklama);
            this.gbKitapEkle.Controls.Add(this.cbEmanetTeslimDurum);
            this.gbKitapEkle.Controls.Add(this.label5);
            this.gbKitapEkle.Controls.Add(this.label2);
            this.gbKitapEkle.Location = new System.Drawing.Point(12, 12);
            this.gbKitapEkle.Name = "gbKitapEkle";
            this.gbKitapEkle.Size = new System.Drawing.Size(389, 216);
            this.gbKitapEkle.TabIndex = 15;
            this.gbKitapEkle.TabStop = false;
            this.gbKitapEkle.Text = "Emanet Düzenle";
            // 
            // lblEmanetNo
            // 
            this.lblEmanetNo.AutoSize = true;
            this.lblEmanetNo.Location = new System.Drawing.Point(120, 27);
            this.lblEmanetNo.Name = "lblEmanetNo";
            this.lblEmanetNo.Size = new System.Drawing.Size(10, 13);
            this.lblEmanetNo.TabIndex = 37;
            this.lblEmanetNo.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Emanet No :";
            // 
            // btnEmanetKaydet
            // 
            this.btnEmanetKaydet.Location = new System.Drawing.Point(123, 162);
            this.btnEmanetKaydet.Name = "btnEmanetKaydet";
            this.btnEmanetKaydet.Size = new System.Drawing.Size(242, 40);
            this.btnEmanetKaydet.TabIndex = 33;
            this.btnEmanetKaydet.Text = "Kaydet";
            this.btnEmanetKaydet.UseVisualStyleBackColor = true;
            this.btnEmanetKaydet.Click += new System.EventHandler(this.btnEmanetKaydet_Click);
            // 
            // tbEmanetAciklama
            // 
            this.tbEmanetAciklama.Location = new System.Drawing.Point(123, 103);
            this.tbEmanetAciklama.Multiline = true;
            this.tbEmanetAciklama.Name = "tbEmanetAciklama";
            this.tbEmanetAciklama.Size = new System.Drawing.Size(242, 53);
            this.tbEmanetAciklama.TabIndex = 32;
            // 
            // cbEmanetTeslimDurum
            // 
            this.cbEmanetTeslimDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmanetTeslimDurum.FormattingEnabled = true;
            this.cbEmanetTeslimDurum.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cbEmanetTeslimDurum.Location = new System.Drawing.Point(123, 50);
            this.cbEmanetTeslimDurum.Name = "cbEmanetTeslimDurum";
            this.cbEmanetTeslimDurum.Size = new System.Drawing.Size(242, 21);
            this.cbEmanetTeslimDurum.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Açıklama/Not :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Teslim Durumu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tahmini Teslim :";
            // 
            // dtEmanetTahminiTeslim
            // 
            this.dtEmanetTahminiTeslim.Location = new System.Drawing.Point(123, 77);
            this.dtEmanetTahminiTeslim.Name = "dtEmanetTahminiTeslim";
            this.dtEmanetTahminiTeslim.Size = new System.Drawing.Size(242, 20);
            this.dtEmanetTahminiTeslim.TabIndex = 35;
            // 
            // frmEmanetDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 238);
            this.Controls.Add(this.gbKitapEkle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmanetDuzenle";
            this.Text = "Emanet Düzenle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEmanetDuzenle_FormClosed);
            this.Load += new System.EventHandler(this.frmEmanetDuzenle_Load);
            this.gbKitapEkle.ResumeLayout(false);
            this.gbKitapEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKitapEkle;
        private System.Windows.Forms.Button btnEmanetKaydet;
        public System.Windows.Forms.ComboBox cbEmanetTeslimDurum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbEmanetAciklama;
        public System.Windows.Forms.Label lblEmanetNo;
        public System.Windows.Forms.DateTimePicker dtEmanetTahminiTeslim;
    }
}