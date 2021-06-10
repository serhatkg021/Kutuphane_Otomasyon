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
    public partial class frmYazarEkle : Form
    {
        Kutuphane_VizeEntities1 model = new Kutuphane_VizeEntities1();

        public frmYazarEkle()
        {
            InitializeComponent();
        }

        private void btnYazarEkle_Click(object sender, EventArgs e)  
        {
            try
            { 
                Yazarlar yeniYazar = new Yazarlar();  
                yeniYazar.yazarAd = tbYazarAd.Text;  
                yeniYazar.yazarSoyad = tbYazarSoyad.Text;
                model.Yazarlar.Add(yeniYazar); 
                model.SaveChanges(); 
                tbYazarAd.Clear(); 
                tbYazarSoyad.Clear();

                MessageBox.Show("Yazar Eklendi.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Yazar Eklenemedi.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmYazarEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKitapIslemler kitapIslemlerForm = (frmKitapIslemler)Application.OpenForms["frmKitapIslemler"];
            kitapIslemlerForm.cbKitapYazar.DataSource = null;
            kitapIslemlerForm.cbKitapYazar.Items.Clear();
            kitapIslemlerForm.cbYazarlarDoldur();
        }
    }
}
