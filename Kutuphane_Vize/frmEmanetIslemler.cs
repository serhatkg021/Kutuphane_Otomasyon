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
    public partial class frmEmanetIslemler : Form
    {
        public frmEmanetIslemler()
        {
            InitializeComponent();
        }

        Kutuphane_VizeEntities1 model = new Kutuphane_VizeEntities1(); 

        public void cbKitaplarDoldur()
        {
            var kitaplarComboBoxList = (from k in model.Kitaplar                             //Kitaplar ComboBox
                                        select new
                                        {
                                            No = k.No,
                                            Kitap = k.kitapAd
                                        }).ToList();

            cbEmanetKitaplar.DataSource = kitaplarComboBoxList;
            cbEmanetKitaplar.ValueMember = "No";
            cbEmanetKitaplar.DisplayMember = "Kitap";
            cbEmanetKitaplar.Text = "Kitap Seçin..";
        }
        public void cbUyelerDoldur()
        {
            var uyelerComboBoxList = (from k in model.Uyeler                             //Üyeler ComboBox
                                        select new
                                        {
                                            No = k.No,
                                            Uye = k.uyeAd + " " + k.uyeSoyad
                                        }).ToList();

            cbEmanetUyeler.DataSource = uyelerComboBoxList;
            cbEmanetUyeler.ValueMember = "No";
            cbEmanetUyeler.DisplayMember = "Uye";
            cbEmanetUyeler.Text = "Yazar Seçin..";
        }

        public void emanetleriGöster()  //Emanetleri listelemek ve farklı yerlerde kullanmak için metot oluşturduk.
        {
            var emanetlerListe = (from k in model.Emanetler      
                                  where k.emanetTeslimDurumu == "Hayır"
                                 select new
                                 {
                                     No = k.No,       
                                     EmanetVerilenKitap = k.Kitaplar.kitapAd,
                                     EmanetVerilenUye = k.Uyeler.uyeAd + " " + k.Uyeler.uyeSoyad,
                                     EmanetVerilenTarih = k.emanetVermeTarih,
                                     EmanetAlinicakTarih = k.emanetAlmaTarih,
                                     EmanetSonIslemTarih = k.emanetIslemTarih,
                                     EmanetAciklama = k.emanetNot,
                                     TeslimDurumu = k.emanetTeslimDurumu
                                 }).ToList();    //Aldığımız kayıtları liste formatına çevirdik.
            dgvEmanetListe.DataSource = emanetlerListe;  //Aldığımız kayıtları göstericeğimiz DataGridView nesnemizin kaynagına eşitledik.
        }

        private void frmEmanetIslemler_Load(object sender, EventArgs e)
        {
            emanetleriGöster();
            cbKitaplarDoldur();
            cbUyelerDoldur();
        }

        private void btnEmanetOlustur_Click(object sender, EventArgs e) 
        {
            Emanetler yeniEmanet = new Emanetler();      //Emanetler tablosu için yeni nesne tanımlıyoruz.
            yeniEmanet.emanetAlmaTarih = Convert.ToDateTime(dtEmanetTahminiTeslim.Text);
            yeniEmanet.kitapNo = Convert.ToInt32(cbEmanetKitaplar.SelectedValue);
            yeniEmanet.uyeNo = Convert.ToInt32(cbEmanetUyeler.SelectedValue); 
            yeniEmanet.emanetNot = Convert.ToString(tbEmanetAciklama.Text);
            yeniEmanet.emanetVermeTarih = DateTime.Now;    
            yeniEmanet.emanetIslemTarih = DateTime.Now;     
            yeniEmanet.emanetTeslimDurumu = "Hayır";
            model.Emanetler.Add(yeniEmanet);  
            model.SaveChanges();   
            cbEmanetKitaplar.Text = "Kitap Seçin..";
            cbEmanetUyeler.Text = "Üye Seçin..";
            tbEmanetAciklama.Clear();
            dtEmanetTahminiTeslim.Value = DateTime.Now;
        }

        private void btnEmanetYenile_Click(object sender, EventArgs e)
        {
            emanetleriGöster(); 
        }

        private void btnEmanetDüzenle_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmanetDuzenle emanetDuzenleForm = new frmEmanetDuzenle();
                // Tablodan seçilen emanetin bilgilerini Emanet Düzenle formundaki ilgili yerlere dolduruyoruz.
                emanetDuzenleForm.lblEmanetNo.Text = dgvEmanetListe.SelectedRows[0].Cells["No"].Value.ToString();
                emanetDuzenleForm.tbEmanetAciklama.Text = dgvEmanetListe.SelectedRows[0].Cells["EmanetAciklama"].Value.ToString();
                emanetDuzenleForm.dtEmanetTahminiTeslim.Text = dgvEmanetListe.SelectedRows[0].Cells["EmanetAlinicakTarih"].Value.ToString();
                emanetDuzenleForm.verilenEmanetTeslimDurum = dgvEmanetListe.SelectedRows[0].Cells["TeslimDurumu"].Value.ToString();
                emanetDuzenleForm.Show();   // Tanımladığımız "emanetDuzenleForm" nesnemizi .Show() ile ekranda gösteriyoruz.

            }
            catch (Exception)
            {
                MessageBox.Show("Düzenlenicek Kaydı Seçmediniz.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnKayitAra_Click(object sender, EventArgs e)
        {
            var emanetlerListe = (from k in model.Emanetler      
                                  where k.Kitaplar.kitapAd == tbKayitAra.Text && k.emanetTeslimDurumu == "Hayır"
                                  select new
                                  {
                                      No = k.No,
                                      EmanetVerilenKitap = k.Kitaplar.kitapAd,   
                                      EmanetVerilenUye = k.Uyeler.uyeAd + " " + k.Uyeler.uyeSoyad, 
                                      EmanetVerilenTarih = k.emanetVermeTarih,
                                      EmanetAlinicakTarih = k.emanetAlmaTarih,
                                      EmanetSonIslemTarih = k.emanetIslemTarih,
                                      EmanetAciklama = k.emanetNot,
                                      TeslimDurumu = k.emanetTeslimDurumu
                                  }).ToList();    //Aldığımız kayıtları liste formatına çevirdik.
            dgvEmanetListe.DataSource = emanetlerListe;  //Aldığımız kayıtları göstericeğimiz DataGridView nesnemizin kaynagına eşitledik.
        }

        private void btnEmanetArsiv_Click(object sender, EventArgs e) 
        {
            frmEmanetArsivi emanetArsivForm = new frmEmanetArsivi();
            emanetArsivForm.Show();  
        }
    }
}
