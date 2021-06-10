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
    public partial class frmUyeIslemler : Form
    {
        public frmUyeIslemler()
        {
            InitializeComponent();
        }

        Kutuphane_VizeEntities1 model = new Kutuphane_VizeEntities1();
        public void uyeleriGöster() //Üyeleri listelemek ve farklı yerlerde kullanmak için metot oluşturduk.
        {
            var uyelerListe = (from k in model.Uyeler    
                               select new
                                 {
                                     No = k.No,                   
                                     UyeAd = k.uyeAd,
                                     UyeSoyad = k.uyeSoyad,
                                     UyeTelefon = k.uyeTelefon,
                                     UyeEposta = k.uyeEposta,
                                     UyeOkul = k.Okullar.okulAd,
                                     UyeAdres = k.uyeAdres,
                                  }).ToList();                   //Aldığımız kayıtları liste formatına dönüştürdük.
            dgvUyeListe.DataSource = uyelerListe;   //Aldığımız kayıtları göstericeğimiz DataGridView nesnemizin kaynagına eşitledik.
        }

        public void cbOkullarDoldur()
        {
            var okulComboBoxList = (from k in model.Okullar                             //Okullar ComboBox
                                   select new
                                   {
                                       No = k.No,
                                       Okul = k.okulAd
                                   }).ToList();

            cbUyeOkul.DataSource = okulComboBoxList;
            cbUyeOkul.ValueMember = "No";
            cbUyeOkul.DisplayMember = "Okul";
            cbUyeOkul.Text = "Okul Seçin..";
        }

        private void frmUyeIslemler_Load(object sender, EventArgs e)
        {
            uyeleriGöster();
            cbOkullarDoldur();
        }

        private void btnOkulEkleForm_Click(object sender, EventArgs e)
        {
            frmOkulEkle okulEkleForm = new frmOkulEkle(); 
            okulEkleForm.Show(); 
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)  
        {
            Uyeler yeniUye = new Uyeler();     
            yeniUye.uyeAd = Convert.ToString(tbUyeAd.Text);       
            yeniUye.uyeSoyad = Convert.ToString(tbUyeSoyad.Text);
            yeniUye.uyeTelefon = Convert.ToString(tbUyeTelefon.Text);
            yeniUye.uyeEposta = Convert.ToString(tbUyeMail.Text);
            yeniUye.okulNo = Convert.ToInt32(cbUyeOkul.SelectedValue);   
            yeniUye.uyeAdres = Convert.ToString(tbUyeAdres.Text);
            model.Uyeler.Add(yeniUye);  
            model.SaveChanges();   
            uyeleriGöster();     
            tbUyeAd.Clear();    
            tbUyeSoyad.Clear();
            tbUyeTelefon.Clear();
            tbUyeMail.Clear();
            tbUyeAdres.Clear();
        }

        private void btnUyeYenile_Click(object sender, EventArgs e) 
        {
            uyeleriGöster(); 
        }


        int id = 0;
        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dgvUyeListe.SelectedRows[0].Cells["No"].Value.ToString()); 
                var seciliUye = model.Uyeler.FirstOrDefault(p => p.No == id);   
                model.Uyeler.Remove(seciliUye); 
                model.SaveChanges();  
                MessageBox.Show("Üye kaydı başarıyla silindi.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
                uyeleriGöster();   //Silinen kayıt sonrası tabloyu yeniliyoruz.
            }
            catch (Exception)
            {
                MessageBox.Show("Silinicek Kaydı Seçmediniz.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUyeDüzenle_Click(object sender, EventArgs e) 
        {
            try
            {
                frmUyeDuzenle frmUyeDüzen = new frmUyeDuzenle();   
                frmUyeDüzen.lblUyeNo.Text = dgvUyeListe.SelectedRows[0].Cells["No"].Value.ToString();       
                frmUyeDüzen.tbUyeAd.Text = dgvUyeListe.SelectedRows[0].Cells["UyeAd"].Value.ToString();     
                frmUyeDüzen.tbUyeSoyad.Text = dgvUyeListe.SelectedRows[0].Cells["UyeSoyad"].Value.ToString();
                frmUyeDüzen.tbUyeTelefon.Text = dgvUyeListe.SelectedRows[0].Cells["UyeTelefon"].Value.ToString();
                frmUyeDüzen.tbUyeMail.Text = dgvUyeListe.SelectedRows[0].Cells["UyeEposta"].Value.ToString();
                frmUyeDüzen.tbUyeAdres.Text = dgvUyeListe.SelectedRows[0].Cells["UyeAdres"].Value.ToString();
                frmUyeDüzen.okulGelenAd = dgvUyeListe.SelectedRows[0].Cells["UyeOkul"].Value.ToString();
                frmUyeDüzen.Show();  // Tanımladığımız "frmUyeDüzen" nesnemizi .Show() ile ekranda gösteriyoruz.
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
            var uyelerListe = (from k in model.Uyeler     
                               where k.uyeAd == tbKayitAra.Text 
                               select new
                               {
                                   No = k.No,                   
                                   UyeAd = k.uyeAd,
                                   UyeSoyad = k.uyeSoyad,
                                   UyeTelefon = k.uyeTelefon,
                                   UyeEposta = k.uyeEposta,
                                   UyeOkul = k.Okullar.okulAd,
                                   UyeAdres = k.uyeAdres,
                               }).ToList();    //Aldığımız kayıtları liste formatına çevirdik.
            dgvUyeListe.DataSource = uyelerListe;  //Aldığımız kayıtları göstericeğimiz DataGridView nesnemizin kaynagına eşitledik.
        }
    }
}
