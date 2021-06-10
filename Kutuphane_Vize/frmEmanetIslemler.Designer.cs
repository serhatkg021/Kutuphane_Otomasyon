namespace Kutuphane_Vize
{
    partial class frmEmanetIslemler
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnKayitAra = new System.Windows.Forms.Button();
            this.tbKayitAra = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEmanetArsiv = new System.Windows.Forms.Button();
            this.btnEmanetYenile = new System.Windows.Forms.Button();
            this.btnEmanetDüzenle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEmanetListe = new System.Windows.Forms.DataGridView();
            this.gbKitapEkle = new System.Windows.Forms.GroupBox();
            this.btnEmanetOlustur = new System.Windows.Forms.Button();
            this.tbEmanetAciklama = new System.Windows.Forms.TextBox();
            this.cbEmanetUyeler = new System.Windows.Forms.ComboBox();
            this.cbEmanetKitaplar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtEmanetTahminiTeslim = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanetListe)).BeginInit();
            this.gbKitapEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnKayitAra);
            this.groupBox4.Controls.Add(this.tbKayitAra);
            this.groupBox4.Location = new System.Drawing.Point(12, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(935, 100);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kayıt Arama";
            // 
            // btnKayitAra
            // 
            this.btnKayitAra.Location = new System.Drawing.Point(23, 57);
            this.btnKayitAra.Name = "btnKayitAra";
            this.btnKayitAra.Size = new System.Drawing.Size(888, 23);
            this.btnKayitAra.TabIndex = 1;
            this.btnKayitAra.Text = "Ara";
            this.btnKayitAra.UseVisualStyleBackColor = true;
            this.btnKayitAra.Click += new System.EventHandler(this.btnKayitAra_Click);
            // 
            // tbKayitAra
            // 
            this.tbKayitAra.Location = new System.Drawing.Point(23, 29);
            this.tbKayitAra.Name = "tbKayitAra";
            this.tbKayitAra.Size = new System.Drawing.Size(888, 20);
            this.tbKayitAra.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEmanetArsiv);
            this.groupBox3.Controls.Add(this.btnEmanetYenile);
            this.groupBox3.Controls.Add(this.btnEmanetDüzenle);
            this.groupBox3.Location = new System.Drawing.Point(426, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 222);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Üye İşlemleri";
            // 
            // btnEmanetArsiv
            // 
            this.btnEmanetArsiv.Location = new System.Drawing.Point(19, 30);
            this.btnEmanetArsiv.Name = "btnEmanetArsiv";
            this.btnEmanetArsiv.Size = new System.Drawing.Size(178, 42);
            this.btnEmanetArsiv.TabIndex = 1;
            this.btnEmanetArsiv.Text = "Emanet Arşivi";
            this.btnEmanetArsiv.UseVisualStyleBackColor = true;
            this.btnEmanetArsiv.Click += new System.EventHandler(this.btnEmanetArsiv_Click);
            // 
            // btnEmanetYenile
            // 
            this.btnEmanetYenile.Location = new System.Drawing.Point(19, 165);
            this.btnEmanetYenile.Name = "btnEmanetYenile";
            this.btnEmanetYenile.Size = new System.Drawing.Size(178, 42);
            this.btnEmanetYenile.TabIndex = 3;
            this.btnEmanetYenile.Text = "Listeyi Yenile";
            this.btnEmanetYenile.UseVisualStyleBackColor = true;
            this.btnEmanetYenile.Click += new System.EventHandler(this.btnEmanetYenile_Click);
            // 
            // btnEmanetDüzenle
            // 
            this.btnEmanetDüzenle.Location = new System.Drawing.Point(19, 94);
            this.btnEmanetDüzenle.Name = "btnEmanetDüzenle";
            this.btnEmanetDüzenle.Size = new System.Drawing.Size(178, 42);
            this.btnEmanetDüzenle.TabIndex = 2;
            this.btnEmanetDüzenle.Text = "Düzenle";
            this.btnEmanetDüzenle.UseVisualStyleBackColor = true;
            this.btnEmanetDüzenle.Click += new System.EventHandler(this.btnEmanetDüzenle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEmanetListe);
            this.groupBox1.Location = new System.Drawing.Point(12, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 245);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet Listesi";
            // 
            // dgvEmanetListe
            // 
            this.dgvEmanetListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmanetListe.Location = new System.Drawing.Point(6, 17);
            this.dgvEmanetListe.Name = "dgvEmanetListe";
            this.dgvEmanetListe.Size = new System.Drawing.Size(923, 222);
            this.dgvEmanetListe.TabIndex = 1;
            // 
            // gbKitapEkle
            // 
            this.gbKitapEkle.Controls.Add(this.dtEmanetTahminiTeslim);
            this.gbKitapEkle.Controls.Add(this.label3);
            this.gbKitapEkle.Controls.Add(this.btnEmanetOlustur);
            this.gbKitapEkle.Controls.Add(this.tbEmanetAciklama);
            this.gbKitapEkle.Controls.Add(this.cbEmanetUyeler);
            this.gbKitapEkle.Controls.Add(this.cbEmanetKitaplar);
            this.gbKitapEkle.Controls.Add(this.label5);
            this.gbKitapEkle.Controls.Add(this.label2);
            this.gbKitapEkle.Controls.Add(this.label1);
            this.gbKitapEkle.Location = new System.Drawing.Point(12, 12);
            this.gbKitapEkle.Name = "gbKitapEkle";
            this.gbKitapEkle.Size = new System.Drawing.Size(389, 222);
            this.gbKitapEkle.TabIndex = 14;
            this.gbKitapEkle.TabStop = false;
            this.gbKitapEkle.Text = "Emanet Oluştur";
            // 
            // btnEmanetOlustur
            // 
            this.btnEmanetOlustur.Location = new System.Drawing.Point(123, 165);
            this.btnEmanetOlustur.Name = "btnEmanetOlustur";
            this.btnEmanetOlustur.Size = new System.Drawing.Size(242, 40);
            this.btnEmanetOlustur.TabIndex = 33;
            this.btnEmanetOlustur.Text = "Oluştur";
            this.btnEmanetOlustur.UseVisualStyleBackColor = true;
            this.btnEmanetOlustur.Click += new System.EventHandler(this.btnEmanetOlustur_Click);
            // 
            // tbEmanetAciklama
            // 
            this.tbEmanetAciklama.Location = new System.Drawing.Point(123, 106);
            this.tbEmanetAciklama.Multiline = true;
            this.tbEmanetAciklama.Name = "tbEmanetAciklama";
            this.tbEmanetAciklama.Size = new System.Drawing.Size(242, 53);
            this.tbEmanetAciklama.TabIndex = 32;
            // 
            // cbEmanetUyeler
            // 
            this.cbEmanetUyeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmanetUyeler.FormattingEnabled = true;
            this.cbEmanetUyeler.Location = new System.Drawing.Point(123, 53);
            this.cbEmanetUyeler.Name = "cbEmanetUyeler";
            this.cbEmanetUyeler.Size = new System.Drawing.Size(242, 21);
            this.cbEmanetUyeler.TabIndex = 27;
            // 
            // cbEmanetKitaplar
            // 
            this.cbEmanetKitaplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmanetKitaplar.FormattingEnabled = true;
            this.cbEmanetKitaplar.Location = new System.Drawing.Point(123, 23);
            this.cbEmanetKitaplar.Name = "cbEmanetKitaplar";
            this.cbEmanetKitaplar.Size = new System.Drawing.Size(242, 21);
            this.cbEmanetKitaplar.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Açıklama/Not :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Alan Üye :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Verilen Kitap :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tahmini Teslim :";
            // 
            // dtEmanetTahminiTeslim
            // 
            this.dtEmanetTahminiTeslim.Location = new System.Drawing.Point(123, 80);
            this.dtEmanetTahminiTeslim.Name = "dtEmanetTahminiTeslim";
            this.dtEmanetTahminiTeslim.Size = new System.Drawing.Size(242, 20);
            this.dtEmanetTahminiTeslim.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kutuphane_Vize.Properties.Resources.kitap_okumak_png_6;
            this.pictureBox1.Location = new System.Drawing.Point(654, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmEmanetIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbKitapEkle);
            this.Name = "frmEmanetIslemler";
            this.Text = "Emanet İşlemleri";
            this.Load += new System.EventHandler(this.frmEmanetIslemler_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanetListe)).EndInit();
            this.gbKitapEkle.ResumeLayout(false);
            this.gbKitapEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnKayitAra;
        private System.Windows.Forms.TextBox tbKayitAra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEmanetArsiv;
        private System.Windows.Forms.Button btnEmanetYenile;
        private System.Windows.Forms.Button btnEmanetDüzenle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEmanetListe;
        private System.Windows.Forms.GroupBox gbKitapEkle;
        private System.Windows.Forms.Button btnEmanetOlustur;
        private System.Windows.Forms.TextBox tbEmanetAciklama;
        public System.Windows.Forms.ComboBox cbEmanetUyeler;
        public System.Windows.Forms.ComboBox cbEmanetKitaplar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtEmanetTahminiTeslim;
        private System.Windows.Forms.Label label3;
    }
}