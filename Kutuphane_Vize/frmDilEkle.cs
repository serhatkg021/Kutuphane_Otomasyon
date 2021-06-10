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
    public partial class frmDilEkle : Form
    {
        public frmDilEkle()
        {
            InitializeComponent();
        }

        Kutuphane_VizeEntities1 model = new Kutuphane_VizeEntities1();

        private void btnDilEkle_Click(object sender, EventArgs e) 
        {
            try
            {
                Diller yeniDil = new Diller();  //Diller tablosuna yeni nesne oluşturduk.
                yeniDil.dilAd = tbDilAd.Text;  
                model.Diller.Add(yeniDil);
                model.SaveChanges(); 
                tbDilAd.Clear();  //İşlem sonunda formdaki ilgili TextBox'ları temizledik.
                MessageBox.Show("Dil Eklendi.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Dil Eklenemedi.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmDilEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKitapIslemler kitapIslemlerForm = (frmKitapIslemler)Application.OpenForms["frmKitapIslemler"];
            kitapIslemlerForm.cbKitapDil.DataSource = null;
            kitapIslemlerForm.cbKitapDil.Items.Clear();
            kitapIslemlerForm.cbDillerDoldur();
        }
    }
}
