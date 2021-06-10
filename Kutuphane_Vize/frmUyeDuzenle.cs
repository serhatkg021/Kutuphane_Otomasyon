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
    public partial class frmUyeDuzenle : Form
    {
        public frmUyeDuzenle()
        {
            InitializeComponent();
        }


        Kutuphane_VizeEntities1 model2 = new Kutuphane_VizeEntities1();

        public string okulGelenAd { get; set; }

        public void cbOkullarDoldur2()
        {
            var okullarComboBoxList2 = (from k in model2.Okullar                             //Yazarlar ComboBox
                                         select new
                                         {
                                             No = k.No,
                                             Okul = k.okulAd
                                         }).ToList();

            cbUyeOkul.DataSource = okullarComboBoxList2;
            cbUyeOkul.ValueMember = "No";
            cbUyeOkul.DisplayMember = "Okul";
            cbUyeOkul.Text = okulGelenAd;
        }
        private void btnUyeGuncelle_Click(object sender, EventArgs e)  
        {
            try
            {
                int uyeNo = Convert.ToInt32(lblUyeNo.Text); 
                var seciliUye = model2.Uyeler.FirstOrDefault(p => p.No == uyeNo);  
                seciliUye.uyeAd = tbUyeAd.Text;
                seciliUye.uyeSoyad = tbUyeSoyad.Text; 
                seciliUye.uyeTelefon = tbUyeTelefon.Text;
                seciliUye.uyeEposta = tbUyeMail.Text;
                seciliUye.okulNo = Convert.ToInt32(cbUyeOkul.SelectedValue);
                seciliUye.uyeAdres = tbUyeAdres.Text;
                model2.SaveChanges();  
                MessageBox.Show("Üye kaydı başarıyla güncellendi.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();   //İşlem bittiginde form ekranını kapadık.
            }
            catch (Exception)
            {
                MessageBox.Show("Üye kaydı güncellenirken hata oluştu. Bilgileri kontol ediniz",
                 ""
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUyeDuzenle_Load(object sender, EventArgs e)
        {
            cbOkullarDoldur2();
        }

        private void frmUyeDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmUyeIslemler uyeIslemlerForm = (frmUyeIslemler)Application.OpenForms["frmUyeIslemler"];
            uyeIslemlerForm.uyeleriGöster();
        }
    }
}
