namespace Kutuphane_Vize
{
    partial class frmUyeIslemler
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
            this.btnUyeYenile = new System.Windows.Forms.Button();
            this.btnUyeSil = new System.Windows.Forms.Button();
            this.btnUyeDüzenle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOkulEkleForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUyeListe = new System.Windows.Forms.DataGridView();
            this.gbKitapEkle = new System.Windows.Forms.GroupBox();
            this.tbUyeMail = new System.Windows.Forms.TextBox();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.tbUyeAdres = new System.Windows.Forms.TextBox();
            this.cbUyeOkul = new System.Windows.Forms.ComboBox();
            this.tbUyeTelefon = new System.Windows.Forms.TextBox();
            this.tbUyeSoyad = new System.Windows.Forms.TextBox();
            this.tbUyeAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeListe)).BeginInit();
            this.gbKitapEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnKayitAra);
            this.groupBox4.Controls.Add(this.tbKayitAra);
            this.groupBox4.Location = new System.Drawing.Point(654, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 100);
            this.groupBox4.TabIndex = 4;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUyeYenile);
            this.groupBox3.Controls.Add(this.btnUyeSil);
            this.groupBox3.Controls.Add(this.btnUyeDüzenle);
            this.groupBox3.Location = new System.Drawing.Point(436, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 187);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Üye İşlemleri";
            // 
            // btnUyeYenile
            // 
            this.btnUyeYenile.Location = new System.Drawing.Point(19, 30);
            this.btnUyeYenile.Name = "btnUyeYenile";
            this.btnUyeYenile.Size = new System.Drawing.Size(178, 42);
            this.btnUyeYenile.TabIndex = 1;
            this.btnUyeYenile.Text = "Liste Yenile";
            this.btnUyeYenile.UseVisualStyleBackColor = true;
            this.btnUyeYenile.Click += new System.EventHandler(this.btnUyeYenile_Click);
            // 
            // btnUyeSil
            // 
            this.btnUyeSil.Location = new System.Drawing.Point(19, 126);
            this.btnUyeSil.Name = "btnUyeSil";
            this.btnUyeSil.Size = new System.Drawing.Size(178, 42);
            this.btnUyeSil.TabIndex = 3;
            this.btnUyeSil.Text = "Sil";
            this.btnUyeSil.UseVisualStyleBackColor = true;
            this.btnUyeSil.Click += new System.EventHandler(this.btnUyeSil_Click);
            // 
            // btnUyeDüzenle
            // 
            this.btnUyeDüzenle.Location = new System.Drawing.Point(19, 78);
            this.btnUyeDüzenle.Name = "btnUyeDüzenle";
            this.btnUyeDüzenle.Size = new System.Drawing.Size(178, 42);
            this.btnUyeDüzenle.TabIndex = 2;
            this.btnUyeDüzenle.Text = "Düzenle";
            this.btnUyeDüzenle.UseVisualStyleBackColor = true;
            this.btnUyeDüzenle.Click += new System.EventHandler(this.btnUyeDüzenle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOkulEkleForm);
            this.groupBox2.Location = new System.Drawing.Point(436, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 135);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diğer Eklemeler";
            // 
            // btnOkulEkleForm
            // 
            this.btnOkulEkleForm.Location = new System.Drawing.Point(19, 24);
            this.btnOkulEkleForm.Name = "btnOkulEkleForm";
            this.btnOkulEkleForm.Size = new System.Drawing.Size(178, 94);
            this.btnOkulEkleForm.TabIndex = 1;
            this.btnOkulEkleForm.Text = "Okul Ekle";
            this.btnOkulEkleForm.UseVisualStyleBackColor = true;
            this.btnOkulEkleForm.Click += new System.EventHandler(this.btnOkulEkleForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUyeListe);
            this.groupBox1.Location = new System.Drawing.Point(12, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 245);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Listesi";
            // 
            // dgvUyeListe
            // 
            this.dgvUyeListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeListe.Location = new System.Drawing.Point(6, 17);
            this.dgvUyeListe.Name = "dgvUyeListe";
            this.dgvUyeListe.Size = new System.Drawing.Size(923, 222);
            this.dgvUyeListe.TabIndex = 1;
            // 
            // gbKitapEkle
            // 
            this.gbKitapEkle.Controls.Add(this.tbUyeMail);
            this.gbKitapEkle.Controls.Add(this.btnUyeEkle);
            this.gbKitapEkle.Controls.Add(this.tbUyeAdres);
            this.gbKitapEkle.Controls.Add(this.cbUyeOkul);
            this.gbKitapEkle.Controls.Add(this.tbUyeTelefon);
            this.gbKitapEkle.Controls.Add(this.tbUyeSoyad);
            this.gbKitapEkle.Controls.Add(this.tbUyeAd);
            this.gbKitapEkle.Controls.Add(this.label6);
            this.gbKitapEkle.Controls.Add(this.label7);
            this.gbKitapEkle.Controls.Add(this.label3);
            this.gbKitapEkle.Controls.Add(this.label4);
            this.gbKitapEkle.Controls.Add(this.label2);
            this.gbKitapEkle.Controls.Add(this.label1);
            this.gbKitapEkle.Location = new System.Drawing.Point(12, 12);
            this.gbKitapEkle.Name = "gbKitapEkle";
            this.gbKitapEkle.Size = new System.Drawing.Size(389, 328);
            this.gbKitapEkle.TabIndex = 1;
            this.gbKitapEkle.TabStop = false;
            this.gbKitapEkle.Text = "Üye Ekle";
            // 
            // tbUyeMail
            // 
            this.tbUyeMail.Location = new System.Drawing.Point(124, 105);
            this.tbUyeMail.Name = "tbUyeMail";
            this.tbUyeMail.Size = new System.Drawing.Size(242, 20);
            this.tbUyeMail.TabIndex = 4;
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Location = new System.Drawing.Point(124, 281);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(242, 28);
            this.btnUyeEkle.TabIndex = 7;
            this.btnUyeEkle.Text = "Ekle";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // tbUyeAdres
            // 
            this.tbUyeAdres.Location = new System.Drawing.Point(124, 158);
            this.tbUyeAdres.Multiline = true;
            this.tbUyeAdres.Name = "tbUyeAdres";
            this.tbUyeAdres.Size = new System.Drawing.Size(242, 117);
            this.tbUyeAdres.TabIndex = 6;
            // 
            // cbUyeOkul
            // 
            this.cbUyeOkul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUyeOkul.FormattingEnabled = true;
            this.cbUyeOkul.Location = new System.Drawing.Point(124, 131);
            this.cbUyeOkul.Name = "cbUyeOkul";
            this.cbUyeOkul.Size = new System.Drawing.Size(242, 21);
            this.cbUyeOkul.TabIndex = 5;
            // 
            // tbUyeTelefon
            // 
            this.tbUyeTelefon.Location = new System.Drawing.Point(124, 79);
            this.tbUyeTelefon.Name = "tbUyeTelefon";
            this.tbUyeTelefon.Size = new System.Drawing.Size(242, 20);
            this.tbUyeTelefon.TabIndex = 3;
            // 
            // tbUyeSoyad
            // 
            this.tbUyeSoyad.Location = new System.Drawing.Point(124, 49);
            this.tbUyeSoyad.Name = "tbUyeSoyad";
            this.tbUyeSoyad.Size = new System.Drawing.Size(242, 20);
            this.tbUyeSoyad.TabIndex = 2;
            // 
            // tbUyeAd
            // 
            this.tbUyeAd.Location = new System.Drawing.Point(124, 21);
            this.tbUyeAd.Name = "tbUyeAd";
            this.tbUyeAd.Size = new System.Drawing.Size(242, 20);
            this.tbUyeAd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefon :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Adres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-posta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Okul :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kutuphane_Vize.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(654, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmUyeIslemler
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
            this.Name = "frmUyeIslemler";
            this.Text = "Üye İşlemleri";
            this.Load += new System.EventHandler(this.frmUyeIslemler_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeListe)).EndInit();
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
        private System.Windows.Forms.Button btnUyeYenile;
        private System.Windows.Forms.Button btnUyeSil;
        private System.Windows.Forms.Button btnUyeDüzenle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOkulEkleForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUyeListe;
        private System.Windows.Forms.GroupBox gbKitapEkle;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.TextBox tbUyeAdres;
        public System.Windows.Forms.ComboBox cbUyeOkul;
        private System.Windows.Forms.TextBox tbUyeTelefon;
        private System.Windows.Forms.TextBox tbUyeSoyad;
        private System.Windows.Forms.TextBox tbUyeAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUyeMail;
        private System.Windows.Forms.Label label7;
    }
}