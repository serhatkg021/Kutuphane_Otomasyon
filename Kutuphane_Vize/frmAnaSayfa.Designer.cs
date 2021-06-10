namespace Kutuphane_Vize
{
    partial class frmAnasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.btnKitapIslemler = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnEmanetIslemler = new System.Windows.Forms.Button();
            this.btnUyeIslemler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKitapIslemler
            // 
            this.btnKitapIslemler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapIslemler.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitapIslemler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKitapIslemler.ImageKey = "kitap-png-3.png";
            this.btnKitapIslemler.ImageList = this.ımageList1;
            this.btnKitapIslemler.Location = new System.Drawing.Point(42, 86);
            this.btnKitapIslemler.Name = "btnKitapIslemler";
            this.btnKitapIslemler.Size = new System.Drawing.Size(230, 148);
            this.btnKitapIslemler.TabIndex = 0;
            this.btnKitapIslemler.Text = "Kitap İşlemleri";
            this.btnKitapIslemler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapIslemler.UseVisualStyleBackColor = true;
            this.btnKitapIslemler.Click += new System.EventHandler(this.btnKitapIslemler_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kitap-png-3.png");
            this.ımageList1.Images.SetKeyName(1, "kitap-okumak-png-6.png");
            this.ımageList1.Images.SetKeyName(2, "unnamed.png");
            // 
            // btnEmanetIslemler
            // 
            this.btnEmanetIslemler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetIslemler.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmanetIslemler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmanetIslemler.ImageKey = "kitap-okumak-png-6.png";
            this.btnEmanetIslemler.ImageList = this.ımageList1;
            this.btnEmanetIslemler.Location = new System.Drawing.Point(291, 86);
            this.btnEmanetIslemler.Name = "btnEmanetIslemler";
            this.btnEmanetIslemler.Size = new System.Drawing.Size(230, 148);
            this.btnEmanetIslemler.TabIndex = 1;
            this.btnEmanetIslemler.Text = "Emanet İşlemleri";
            this.btnEmanetIslemler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmanetIslemler.UseVisualStyleBackColor = true;
            this.btnEmanetIslemler.Click += new System.EventHandler(this.btnEmanetIslemler_Click);
            // 
            // btnUyeIslemler
            // 
            this.btnUyeIslemler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeIslemler.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnUyeIslemler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUyeIslemler.ImageKey = "unnamed.png";
            this.btnUyeIslemler.ImageList = this.ımageList1;
            this.btnUyeIslemler.Location = new System.Drawing.Point(538, 86);
            this.btnUyeIslemler.Name = "btnUyeIslemler";
            this.btnUyeIslemler.Size = new System.Drawing.Size(230, 148);
            this.btnUyeIslemler.TabIndex = 2;
            this.btnUyeIslemler.Text = "Üye İşlemleri";
            this.btnUyeIslemler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUyeIslemler.UseVisualStyleBackColor = true;
            this.btnUyeIslemler.Click += new System.EventHandler(this.btnUyeIslemler_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.btnUyeIslemler);
            this.Controls.Add(this.btnEmanetIslemler);
            this.Controls.Add(this.btnKitapIslemler);
            this.Name = "frmAnasayfa";
            this.Text = "Kütüphane";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKitapIslemler;
        private System.Windows.Forms.Button btnEmanetIslemler;
        private System.Windows.Forms.Button btnUyeIslemler;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

