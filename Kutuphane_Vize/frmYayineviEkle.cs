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
    public partial class frmYayineviEkle : Form
    {
        public frmYayineviEkle()
        {
            InitializeComponent();
        }

        Kutuphane_VizeEntities1 model = new Kutuphane_VizeEntities1();
        
        private void btnYayineviEkle_Click(object sender, EventArgs e)  
        {
            try
            {
                Yayınevi yeniYayinevi = new Yayınevi();  
                yeniYayinevi.yayinEviAd = tbYayineviAd.Text;  
                model.Yayınevi.Add(yeniYayinevi); 
                model.SaveChanges();  
                tbYayineviAd.Clear();  
                MessageBox.Show("Yayın Evi Eklendi.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Yayın Evi Eklenemedi.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmYayineviEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKitapIslemler kitapIslemlerForm = (frmKitapIslemler)Application.OpenForms["frmKitapIslemler"];
            kitapIslemlerForm.cbKitapYayinEv.DataSource = null;
            kitapIslemlerForm.cbKitapYayinEv.Items.Clear();
            kitapIslemlerForm.cbYayineviDoldur();
        }
    }
}
