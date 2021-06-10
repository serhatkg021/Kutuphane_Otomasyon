namespace Kutuphane_Vize
{
    partial class frmKitapIslemler
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
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.tbKitapAciklama = new System.Windows.Forms.TextBox();
            this.cbKitapDil = new System.Windows.Forms.ComboBox();
            this.cbKitapYayinEv = new System.Windows.Forms.ComboBox();
            this.tbKitapSayfaSayi = new System.Windows.Forms.TextBox();
            this.tbKitapBaskiYil = new System.Windows.Forms.TextBox();
            this.cbKitapTur = new System.Windows.Forms.ComboBox();
            this.cbKitapYazar = new System.Windows.Forms.ComboBox();
            this.tbKitapAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKitapListe = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTurEkle = new System.Windows.Forms.Button();
            this.btnYayineviEkle = new System.Windows.Forms.Button();
            this.btnDilEkle = new System.Windows.Forms.Button();
            this.btnYazarEkleForm = new System.Windows.Forms.Button();
            this.btnKitapDüzenle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKitapYenile = new System.Windows.Forms.Button();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnKayitAra = new System.Windows.Forms.Button();
            this.tbKayitAra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbKitapEkle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapListe)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKitapEkle
            // 
            this.gbKitapEkle.Controls.Add(this.btnKitapEkle);
            this.gbKitapEkle.Controls.Add(this.tbKitapAciklama);
            this.gbKitapEkle.Controls.Add(this.cbKitapDil);
            this.gbKitapEkle.Controls.Add(this.cbKitapYayinEv);
            this.gbKitapEkle.Controls.Add(this.tbKitapSayfaSayi);
            this.gbKitapEkle.Controls.Add(this.tbKitapBaskiYil);
            this.gbKitapEkle.Controls.Add(this.cbKitapTur);
            this.gbKitapEkle.Controls.Add(this.cbKitapYazar);
            this.gbKitapEkle.Controls.Add(this.tbKitapAd);
            this.gbKitapEkle.Controls.Add(this.label5);
            this.gbKitapEkle.Controls.Add(this.label6);
            this.gbKitapEkle.Controls.Add(this.label7);
            this.gbKitapEkle.Controls.Add(this.label8);
            this.gbKitapEkle.Controls.Add(this.label3);
            this.gbKitapEkle.Controls.Add(this.label4);
            this.gbKitapEkle.Controls.Add(this.label2);
            this.gbKitapEkle.Controls.Add(this.label1);
            this.gbKitapEkle.Location = new System.Drawing.Point(12, 12);
            this.gbKitapEkle.Name = "gbKitapEkle";
            this.gbKitapEkle.Size = new System.Drawing.Size(389, 328);
            this.gbKitapEkle.TabIndex = 1;
            this.gbKitapEkle.TabStop = false;
            this.gbKitapEkle.Text = "Kitap Ekle";
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(124, 281);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(242, 28);
            this.btnKitapEkle.TabIndex = 16;
            this.btnKitapEkle.Text = "Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // tbKitapAciklama
            // 
            this.tbKitapAciklama.Location = new System.Drawing.Point(124, 211);
            this.tbKitapAciklama.Multiline = true;
            this.tbKitapAciklama.Name = "tbKitapAciklama";
            this.tbKitapAciklama.Size = new System.Drawing.Size(242, 52);
            this.tbKitapAciklama.TabIndex = 15;
            // 
            // cbKitapDil
            // 
            this.cbKitapDil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKitapDil.FormattingEnabled = true;
            this.cbKitapDil.Location = new System.Drawing.Point(124, 184);
            this.cbKitapDil.Name = "cbKitapDil";
            this.cbKitapDil.Size = new System.Drawing.Size(242, 21);
            this.cbKitapDil.TabIndex = 14;
            // 
            // cbKitapYayinEv
            // 
            this.cbKitapYayinEv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKitapYayinEv.FormattingEnabled = true;
            this.cbKitapYayinEv.Location = new System.Drawing.Point(124, 157);
            this.cbKitapYayinEv.Name = "cbKitapYayinEv";
            this.cbKitapYayinEv.Size = new System.Drawing.Size(242, 21);
            this.cbKitapYayinEv.TabIndex = 13;
            // 
            // tbKitapSayfaSayi
            // 
            this.tbKitapSayfaSayi.Location = new System.Drawing.Point(124, 131);
            this.tbKitapSayfaSayi.Name = "tbKitapSayfaSayi";
            this.tbKitapSayfaSayi.Size = new System.Drawing.Size(242, 20);
            this.tbKitapSayfaSayi.TabIndex = 12;
            // 
            // tbKitapBaskiYil
            // 
            this.tbKitapBaskiYil.Location = new System.Drawing.Point(124, 105);
            this.tbKitapBaskiYil.Name = "tbKitapBaskiYil";
            this.tbKitapBaskiYil.Size = new System.Drawing.Size(242, 20);
            this.tbKitapBaskiYil.TabIndex = 11;
            // 
            // cbKitapTur
            // 
            this.cbKitapTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKitapTur.FormattingEnabled = true;
            this.cbKitapTur.Location = new System.Drawing.Point(124, 78);
            this.cbKitapTur.Name = "cbKitapTur";
            this.cbKitapTur.Size = new System.Drawing.Size(242, 21);
            this.cbKitapTur.TabIndex = 10;
            // 
            // cbKitapYazar
            // 
            this.cbKitapYazar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKitapYazar.FormattingEnabled = true;
            this.cbKitapYazar.Location = new System.Drawing.Point(124, 48);
            this.cbKitapYazar.Name = "cbKitapYazar";
            this.cbKitapYazar.Size = new System.Drawing.Size(242, 21);
            this.cbKitapYazar.TabIndex = 9;
            // 
            // tbKitapAd
            // 
            this.tbKitapAd.Location = new System.Drawing.Point(124, 21);
            this.tbKitapAd.Name = "tbKitapAd";
            this.tbKitapAd.Size = new System.Drawing.Size(242, 20);
            this.tbKitapAd.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Açıklama/Not :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Türü :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Yayın Evi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Dili :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Baskı Yılı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sayfa Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazarı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKitapListe);
            this.groupBox1.Location = new System.Drawing.Point(12, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 245);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Listesi";
            // 
            // dgvKitapListe
            // 
            this.dgvKitapListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitapListe.Location = new System.Drawing.Point(6, 17);
            this.dgvKitapListe.Name = "dgvKitapListe";
            this.dgvKitapListe.Size = new System.Drawing.Size(923, 222);
            this.dgvKitapListe.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTurEkle);
            this.groupBox2.Controls.Add(this.btnYayineviEkle);
            this.groupBox2.Controls.Add(this.btnDilEkle);
            this.groupBox2.Controls.Add(this.btnYazarEkleForm);
            this.groupBox2.Location = new System.Drawing.Point(436, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 135);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diğer Eklemeler";
            // 
            // btnTurEkle
            // 
            this.btnTurEkle.Location = new System.Drawing.Point(111, 19);
            this.btnTurEkle.Name = "btnTurEkle";
            this.btnTurEkle.Size = new System.Drawing.Size(86, 44);
            this.btnTurEkle.TabIndex = 3;
            this.btnTurEkle.Text = "Tür Ekle";
            this.btnTurEkle.UseVisualStyleBackColor = true;
            this.btnTurEkle.Click += new System.EventHandler(this.btnTurEkle_Click);
            // 
            // btnYayineviEkle
            // 
            this.btnYayineviEkle.Location = new System.Drawing.Point(19, 73);
            this.btnYayineviEkle.Name = "btnYayineviEkle";
            this.btnYayineviEkle.Size = new System.Drawing.Size(86, 45);
            this.btnYayineviEkle.TabIndex = 2;
            this.btnYayineviEkle.Text = "Yayın Evi Ekle";
            this.btnYayineviEkle.UseVisualStyleBackColor = true;
            this.btnYayineviEkle.Click += new System.EventHandler(this.btnYayineviEkle_Click);
            // 
            // btnDilEkle
            // 
            this.btnDilEkle.Location = new System.Drawing.Point(111, 73);
            this.btnDilEkle.Name = "btnDilEkle";
            this.btnDilEkle.Size = new System.Drawing.Size(86, 45);
            this.btnDilEkle.TabIndex = 1;
            this.btnDilEkle.Text = "Dil Ekle";
            this.btnDilEkle.UseVisualStyleBackColor = true;
            this.btnDilEkle.Click += new System.EventHandler(this.btnDilEkle_Click);
            // 
            // btnYazarEkleForm
            // 
            this.btnYazarEkleForm.Location = new System.Drawing.Point(19, 19);
            this.btnYazarEkleForm.Name = "btnYazarEkleForm";
            this.btnYazarEkleForm.Size = new System.Drawing.Size(86, 44);
            this.btnYazarEkleForm.TabIndex = 0;
            this.btnYazarEkleForm.Text = "Yazar Ekle";
            this.btnYazarEkleForm.UseVisualStyleBackColor = true;
            this.btnYazarEkleForm.Click += new System.EventHandler(this.btnYazarEkleForm_Click);
            // 
            // btnKitapDüzenle
            // 
            this.btnKitapDüzenle.Location = new System.Drawing.Point(19, 78);
            this.btnKitapDüzenle.Name = "btnKitapDüzenle";
            this.btnKitapDüzenle.Size = new System.Drawing.Size(178, 42);
            this.btnKitapDüzenle.TabIndex = 4;
            this.btnKitapDüzenle.Text = "Düzenle";
            this.btnKitapDüzenle.UseVisualStyleBackColor = true;
            this.btnKitapDüzenle.Click += new System.EventHandler(this.btnKitapDüzenle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKitapYenile);
            this.groupBox3.Controls.Add(this.btnKitapSil);
            this.groupBox3.Controls.Add(this.btnKitapDüzenle);
            this.groupBox3.Location = new System.Drawing.Point(436, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 187);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap İşlemleri";
            // 
            // btnKitapYenile
            // 
            this.btnKitapYenile.Location = new System.Drawing.Point(19, 30);
            this.btnKitapYenile.Name = "btnKitapYenile";
            this.btnKitapYenile.Size = new System.Drawing.Size(178, 42);
            this.btnKitapYenile.TabIndex = 7;
            this.btnKitapYenile.Text = "Liste Yenile";
            this.btnKitapYenile.UseVisualStyleBackColor = true;
            this.btnKitapYenile.Click += new System.EventHandler(this.btnKitapYenile_Click);
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Location = new System.Drawing.Point(19, 126);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(178, 42);
            this.btnKitapSil.TabIndex = 5;
            this.btnKitapSil.Text = "Sil";
            this.btnKitapSil.UseVisualStyleBackColor = true;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnKayitAra);
            this.groupBox4.Controls.Add(this.tbKayitAra);
            this.groupBox4.Location = new System.Drawing.Point(654, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kayıt Arama";
            // 
            // btnKayitAra
            // 
            this.btnKayitAra.Location = new System.Drawing.Point(23, 57);
            this.btnKayitAra.Name = "btnKayitAra";
            this.btnKayitAra.Size = new System.Drawing.Size(244, 23);
            this.btnKayitAra.TabIndex = 1;
            this.btnKayitAra.Text = "Ara";
            this.btnKayitAra.UseVisualStyleBackColor = true;
            this.btnKayitAra.Click += new System.EventHandler(this.btnKayitAra_Click);
            // 
            // tbKayitAra
            // 
            this.tbKayitAra.Location = new System.Drawing.Point(23, 29);
            this.tbKayitAra.Name = "tbKayitAra";
            this.tbKayitAra.Size = new System.Drawing.Size(244, 20);
            this.tbKayitAra.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kutuphane_Vize.Properties.Resources.kitap_png_3;
            this.pictureBox1.Location = new System.Drawing.Point(654, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmKitapIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbKitapEkle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKitapIslemler";
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.frmKitapIslemler_Load);
            this.gbKitapEkle.ResumeLayout(false);
            this.gbKitapEkle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapListe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKitapEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKitapListe;
        private System.Windows.Forms.TextBox tbKitapAciklama;
        private System.Windows.Forms.TextBox tbKitapSayfaSayi;
        private System.Windows.Forms.TextBox tbKitapBaskiYil;
        private System.Windows.Forms.TextBox tbKitapAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTurEkle;
        private System.Windows.Forms.Button btnYayineviEkle;
        private System.Windows.Forms.Button btnDilEkle;
        private System.Windows.Forms.Button btnYazarEkleForm;
        private System.Windows.Forms.Button btnKitapDüzenle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.Button btnKitapYenile;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnKayitAra;
        private System.Windows.Forms.TextBox tbKayitAra;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox cbKitapYazar;
        public System.Windows.Forms.ComboBox cbKitapDil;
        public System.Windows.Forms.ComboBox cbKitapYayinEv;
        public System.Windows.Forms.ComboBox cbKitapTur;
    }
}