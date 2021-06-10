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
    public partial class frmKitapIslemler : Form
    {
        public frmKitapIslemler()
        {
            InitializeComponent();
        }

        Kutuphane_VizeEntities1 model = new Kutuphane_VizeEntities1(); 
        public void kitaplariGöster()   // Kitapları göstermek ve diğer formlarda kullanabilmek için public metot oluşturuyoruz.
        {
            var kitaplarListe = (from k in model.Kitaplar    
                                    select new
                                    {
                                        No = k.No,         
                                        KitapAd = k.kitapAd,                 
                                        Yazar = k.Yazarlar.yazarAd + " " + k.Yazarlar.yazarSoyad, 
                                        Tür = k.Tur.turAd,
                                        SayfaSayısı = k.kitapSayfaSayi,
                                        YayınEvi = k.Yayınevi.yayinEviAd,
                                        BaskıYıl = k.kitapBaskiYil,
                                        Dil = k.Diller.dilAd,
                                        Açıklama = k.kitapAciklama
                                    }).ToList();                   
            dgvKitapListe.DataSource = kitaplarListe;   
        }
        public void cbYazarlarDoldur() // Yazarları Comboboxa doldurmak ve diğer formlarda kullanabilmek için public metot oluşturuyoruz.
        {
            var yazarlarComboBoxList = (from k in model.Yazarlar    
                                        select new
                                        {
                                            No = k.No,           
                                            Yazar = k.yazarAd + " " + k.yazarSoyad 
                                        }).ToList();     //Aldığımız kayıtları liste formatına dönüştürdük.
            cbKitapYazar.DataSource = yazarlarComboBoxList;  //Aldığımız kayıtları doldurucağımız ComboBox nesnemizin kaynagına eşitledik.
            cbKitapYazar.ValueMember = "No";    
            cbKitapYazar.DisplayMember = "Yazar";
            cbKitapYazar.Text = "Yazar Seçin.."; 
        }
        public void cbTurlerDoldur()
        {
            var turComboBoxList = (from k in model.Tur                             //Türler ComboBox
                                    select new
                                    {
                                        No = k.No,
                                        Tur = k.turAd
                                    }).ToList();
            cbKitapTur.DataSource = turComboBoxList;
            cbKitapTur.ValueMember = "No";
            cbKitapTur.DisplayMember = "Tur";
            cbKitapTur.Text = "Tür Seçin..";
        }
        public void cbYayineviDoldur()
        {
            var yayineviComboBoxList = (from k in model.Yayınevi                             //Yayınevi ComboBox
                                        select new
                                        {
                                            No = k.No,
                                            Yayinevi = k.yayinEviAd
                                        }).ToList();
            cbKitapYayinEv.DataSource = yayineviComboBoxList;
            cbKitapYayinEv.ValueMember = "No";
            cbKitapYayinEv.DisplayMember = "Yayinevi";
            cbKitapYayinEv.Text = "Yayınevi Seçin..";
        }
        public void cbDillerDoldur()
        {
            var dilComboBoxList = (from k in model.Diller                             //Dil ComboBox
                                    select new
                                    {
                                        No = k.No,
                                        Dil = k.dilAd
                                    }).ToList();
            cbKitapDil.DataSource = dilComboBoxList;
            cbKitapDil.ValueMember = "No";
            cbKitapDil.DisplayMember = "Dil";
            cbKitapDil.Text = "Dil Seçin..";
        }
        private void frmKitapIslemler_Load(object sender, EventArgs e)
        {
            kitaplariGöster();
            cbYazarlarDoldur();
            cbTurlerDoldur();
            cbYayineviDoldur();
            cbDillerDoldur();
        }
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitaplar yeniKitap = new Kitaplar();
            yeniKitap.kitapAd = Convert.ToString(tbKitapAd.Text);       
            yeniKitap.kitapAciklama = Convert.ToString(tbKitapAciklama.Text);
            yeniKitap.kitapBaskiYil = Convert.ToInt32(Convert.ToString(tbKitapBaskiYil.Text));
            yeniKitap.kitapSayfaSayi = Convert.ToInt32(tbKitapSayfaSayi.Text);
            yeniKitap.yazarNo = Convert.ToInt32(cbKitapYazar.SelectedValue);    
            yeniKitap.turNo = Convert.ToInt32(cbKitapTur.SelectedValue);
            yeniKitap.dilNo = Convert.ToInt32(cbKitapDil.SelectedValue);
            yeniKitap.yayinEviNo = Convert.ToInt32(cbKitapYayinEv.SelectedValue);
            model.Kitaplar.Add(yeniKitap);
            model.SaveChanges();
            kitaplariGöster();      //Eklenen kayıt sonrası kaydın görünmesi adına tabloyu yeniliyoruz.

            tbKitapBaskiYil.Clear();    //Son olarak girilen bilgilerin textboxlarını boşaltıyoruz.
            tbKitapSayfaSayi.Clear();
            tbKitapAd.Clear();
            tbKitapAciklama.Clear();
        }
        private void btnKitapDüzenle_Click(object sender, EventArgs e)
        {
            try
            {
            frmKitapDuzenle frmKitapDüzen = new frmKitapDuzenle();   
            frmKitapDüzen.lblKitapNo.Text = dgvKitapListe.SelectedRows[0].Cells["No"].Value.ToString();
            frmKitapDüzen.tbKitapAd.Text = dgvKitapListe.SelectedRows[0].Cells["KitapAd"].Value.ToString(); 
            frmKitapDüzen.tbKitapBaskiYil.Text = dgvKitapListe.SelectedRows[0].Cells["BaskıYıl"].Value.ToString();
            frmKitapDüzen.tbKitapSayfaSayi.Text = dgvKitapListe.SelectedRows[0].Cells["SayfaSayısı"].Value.ToString();
            frmKitapDüzen.tbKitapAciklama.Text = dgvKitapListe.SelectedRows[0].Cells["Açıklama"].Value.ToString();
            frmKitapDüzen.yazarGelenAd = dgvKitapListe.SelectedRows[0].Cells["Yazar"].Value.ToString();       
            frmKitapDüzen.yayineviGelenAd = dgvKitapListe.SelectedRows[0].Cells["YayınEvi"].Value.ToString(); 
            frmKitapDüzen.dilGelenAd = dgvKitapListe.SelectedRows[0].Cells["Dil"].Value.ToString();
            frmKitapDüzen.turGelenAd = dgvKitapListe.SelectedRows[0].Cells["Tür"].Value.ToString();
            frmKitapDüzen.Show();  // Tanımladığımız "frmKitapDüzen" nesnemizi .Show() ile ekranda gösteriyoruz.
            }
            catch (Exception)
            {
                MessageBox.Show("Düzenlenicek Kaydı Seçmediniz.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int id = 0;
        private void btnKitapSil_Click(object sender, EventArgs e)      
        {
            try
            {
                id = Convert.ToInt32(dgvKitapListe.SelectedRows[0].Cells["No"].Value.ToString()); 
                var seciliKitap = model.Kitaplar.FirstOrDefault(p => p.No == id);
                model.Kitaplar.Remove(seciliKitap);
                model.SaveChanges();
                MessageBox.Show("Kitap kaydı başarıyla silindi.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kitaplariGöster();   //Silinen kayıt sonrası tabloyu yeniliyoruz.
            }
            catch (Exception)
            {
                MessageBox.Show("Silinicek Kaydı Seçmediniz.","", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKitapYenile_Click(object sender, EventArgs e)
        {
            kitaplariGöster();      //Kitapları doldurmak için tanımladığımız metotu çağırıyoruz.
        }

        private void btnKayitAra_Click(object sender, EventArgs e)
        {
            var kitaplarListe = (from k in model.Kitaplar     
                                    where k.kitapAd == tbKayitAra.Text
                                    select new
                                    {
                                        No = k.No,
                                        KitapAd = k.kitapAd,                  
                                        Yazar = k.Yazarlar.yazarAd + " " + k.Yazarlar.yazarSoyad, 
                                        Tür = k.Tur.turAd,
                                        SayfaSayısı = k.kitapSayfaSayi,
                                        YayınEvi = k.Yayınevi.yayinEviAd,
                                        BaskıYıl = k.kitapBaskiYil,
                                        Dil = k.Diller.dilAd,
                                        Açıklama = k.kitapAciklama
                                    }).ToList();    //Aldığımız kayıtları liste formatına çevirdik.
            dgvKitapListe.DataSource = kitaplarListe;  //Aldığımız kayıtları göstericeğimiz DataGridView nesnemizin kaynagına eşitledik.
        }
        private void btnYazarEkleForm_Click(object sender, EventArgs e)
        {
            frmYazarEkle yazarEkleForm = new frmYazarEkle(); 
            yazarEkleForm.Show();  
        }
        private void btnTurEkle_Click(object sender, EventArgs e)
        {
            frmTurEkle turEkleForm = new frmTurEkle(); 
            turEkleForm.Show();  
        }
        private void btnYayineviEkle_Click(object sender, EventArgs e)
        {
            frmYayineviEkle yayineviEkleForm = new frmYayineviEkle();
            yayineviEkleForm.Show();  
        }
        private void btnDilEkle_Click(object sender, EventArgs e)
        {
            frmDilEkle dilEkleForm = new frmDilEkle(); 
            dilEkleForm.Show();   
        }
    }
}
