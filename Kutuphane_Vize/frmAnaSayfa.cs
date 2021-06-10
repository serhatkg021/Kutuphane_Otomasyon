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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        private void btnKitapIslemler_Click(object sender, EventArgs e)   
        {
            frmKitapIslemler kitapIslemler = new frmKitapIslemler();   
            kitapIslemler.Show();      // Tanımladığımız "kitapIslemler" nesnemizi .Show() ile ekranda gösteriyoruz.
        }
        private void btnUyeIslemler_Click(object sender, EventArgs e)   
        {
            frmUyeIslemler uyeIslemler = new frmUyeIslemler();
            uyeIslemler.Show();      // Tanımladığımız "uyeIslemler" nesnemizi .Show() ile ekranda gösteriyoruz.
        }
        private void btnEmanetIslemler_Click(object sender, EventArgs e)   
        {
            frmEmanetIslemler emanetIslemler = new frmEmanetIslemler(); 
            emanetIslemler.Show();      // Tanımladığımız "emanetIslemler" nesnemizi .Show() ile ekranda gösteriyoruz.
        }
    }
}
