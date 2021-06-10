using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Vize
{
    public partial class frmKitapDuzenle : Form
    {
        public frmKitapDuzenle()
        {
            InitializeComponent();
        }

        Kutuphane_VizeEntities1 model2 = new Kutuphane_VizeEntities1();

        public string yazarGelenAd { get; set; }
        public string turGelenAd { get; set; }
        public string yayineviGelenAd { get; set; }
        public string dilGelenAd { get; set; }


        public void cbYazarlarDoldur2()
        {
            var yazarlarComboBoxList2 = (from k in model2.Yazarlar                             //Yazarlar ComboBox
                                         select new
                                         {
                                             No = k.No,
                                             Yazar = k.yazarAd + " " + k.yazarSoyad
                                         }).ToList();

            cbKitapYazarD.DataSource = yazarlarComboBoxList2;
            cbKitapYazarD.ValueMember = "No";
            cbKitapYazarD.DisplayMember = "Yazar";
            cbKitapYazarD.Text = yazarGelenAd;
        }

        public void cbTurlerDoldur2()
        {
            var turComboBoxList2 = (from k in model2.Tur                             //Türler ComboBox
                                    select new
                                    {
                                        No = k.No,
                                        Tur = k.turAd
                                    }).ToList();

            cbKitapTurD.DataSource = turComboBoxList2;
            cbKitapTurD.ValueMember = "No";
            cbKitapTurD.DisplayMember = "Tur";
            cbKitapTurD.Text = turGelenAd;

        }
        public void cbYayineviDoldur2()
        {
            var yayineviComboBoxList2 = (from k in model2.Yayınevi                             //Yayınevi ComboBox
                                         select new
                                         {
                                             No = k.No,
                                             Yayinevi = k.yayinEviAd
                                         }).ToList();

            cbKitapYayinEvD.DataSource = yayineviComboBoxList2;
            cbKitapYayinEvD.ValueMember = "No";
            cbKitapYayinEvD.DisplayMember = "Yayinevi";
            cbKitapYayinEvD.Text = yayineviGelenAd;
        }
        public void cbDillerDoldur2()
        {
            var dilComboBoxList2 = (from k in model2.Diller                             //Dil ComboBox
                                    select new
                                    {
                                        No = k.No,
                                        Dil = k.dilAd
                                    }).ToList();

            cbKitapDilD.DataSource = dilComboBoxList2;
            cbKitapDilD.ValueMember = "No";
            cbKitapDilD.DisplayMember = "Dil";
            cbKitapDilD.Text = dilGelenAd;
        }

        private void btnKitapGüncelle_Click(object sender, EventArgs e)  //Kitap Güncelleme Butonu Tıklandığında
        {
            try 
            {
            int kitapNo = Convert.ToInt32(lblKitapNo.Text);     
            var seciliKitap = model2.Kitaplar.FirstOrDefault(p => p.No == kitapNo);  
            seciliKitap.kitapAd = tbKitapAd.Text;
            seciliKitap.kitapAciklama = tbKitapAciklama.Text;
            seciliKitap.kitapBaskiYil = Convert.ToInt32(tbKitapBaskiYil.Text);  
            seciliKitap.kitapSayfaSayi = Convert.ToInt32(tbKitapSayfaSayi.Text);
            seciliKitap.yazarNo = Convert.ToInt32(cbKitapYazarD.SelectedValue);
            seciliKitap.turNo = Convert.ToInt32(cbKitapTurD.SelectedValue);
            seciliKitap.dilNo = Convert.ToInt32(cbKitapDilD.SelectedValue);
            seciliKitap.yayinEviNo = Convert.ToInt32(cbKitapYayinEvD.SelectedValue);
            model2.SaveChanges();   
            MessageBox.Show("Kitap kaydı başarıyla güncellendi.",
            ""
            , MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();   //İşlem bittiginde form ekranını kapadık.
            }
            catch (Exception)
            {
                MessageBox.Show("Kitap kaydı güncellenirken hata oluştu. Bilgileri kontol ediniz",
                 ""
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmKitapDuzenle_Load(object sender, EventArgs e)
        {
            cbYazarlarDoldur2();
            cbTurlerDoldur2();
            cbYayineviDoldur2();
            cbDillerDoldur2();

        }

        private void frmKitapDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKitapIslemler kitapIslemlerForm = (frmKitapIslemler)Application.OpenForms["frmKitapIslemler"];
            kitapIslemlerForm.kitaplariGöster();
        }
    }
}
