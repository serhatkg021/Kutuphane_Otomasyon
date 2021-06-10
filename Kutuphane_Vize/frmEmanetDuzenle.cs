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
    public partial class frmEmanetDuzenle : Form
    {
        public frmEmanetDuzenle()
        {
            InitializeComponent();
        }

        Kutuphane_VizeEntities1 model = new Kutuphane_VizeEntities1();
        public string verilenEmanetTeslimDurum { get; set; }


        private void frmEmanetDuzenle_Load(object sender, EventArgs e)
        {
            cbEmanetTeslimDurum.Text = verilenEmanetTeslimDurum;
        }

        private void btnEmanetKaydet_Click(object sender, EventArgs e)
        {
            try
            {
            int emanetNo = Convert.ToInt32(lblEmanetNo.Text);  
            var seciliEmanet = model.Emanetler.FirstOrDefault(p => p.No == emanetNo);
            seciliEmanet.emanetTeslimDurumu = cbEmanetTeslimDurum.Text;   
            seciliEmanet.emanetAlmaTarih = Convert.ToDateTime(dtEmanetTahminiTeslim.Text);
            seciliEmanet.emanetNot = tbEmanetAciklama.Text;
            seciliEmanet.emanetIslemTarih = DateTime.Now;
            model.SaveChanges();
            MessageBox.Show("Emanet kaydı başarıyla güncellendi.",
            ""
            , MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();   // İşlem bittiğinde Emanet Düzenle formunu kapatıyoruz.
            }
            catch (Exception)
            {
                MessageBox.Show("Emanet kaydı güncellenirken hata oluştu. Bilgileri kontol ediniz",
                    ""
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEmanetDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmEmanetIslemler emanetIslemlerForm = (frmEmanetIslemler)Application.OpenForms["frmEmanetIslemler"];
            emanetIslemlerForm.emanetleriGöster();
        }
    }
}
