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
    public partial class frmEmanetArsivi : Form
    {
        public frmEmanetArsivi()
        {
            InitializeComponent();
        }

        Kutuphane_VizeEntities1 model = new Kutuphane_VizeEntities1();

        public void emanetlerArsivGöster()  //Emanet Arşivini listelemek ve farklı yerlerde kullanmak için metot oluşturduk.
        {
            var emanetlerArsivListe = (from k in model.Emanetler 
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
            dgvEmanetArsiv.DataSource = emanetlerArsivListe;  //Aldığımız kayıtları göstericeğimiz DataGridView nesnemizin kaynagına eşitledik.
        }
        private void frmEmanetArsivi_Load(object sender, EventArgs e)
        {
            emanetlerArsivGöster();
        }

        private void btnKayitAra_Click(object sender, EventArgs e)
        {
            var emanetlerArsivAramaListe = (from k in model.Emanetler 
                        where k.Kitaplar.kitapAd == tbKayitAra.Text
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
                        }).ToList();   //Aldığımız kayıtları liste formatına çevirdik.

            dgvEmanetArsiv.DataSource = emanetlerArsivAramaListe;   //Aldığımız kayıtları göstericeğimiz DataGridView nesnemizin kaynagına eşitledik.
        }

        private void btnArsivListeYenile_Click(object sender, EventArgs e) 
        {
            emanetlerArsivGöster();   //DataGridViewin yenilenmesi için arşiv listesini gösteren metotu çağırdık.
        }
    }
}
