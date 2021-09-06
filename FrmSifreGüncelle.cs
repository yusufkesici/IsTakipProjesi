using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace garantiTakip
{
    public partial class FrmSifreGüncelle : Form
    {
        public FrmSifreGüncelle()
        {
            InitializeComponent();
        }
        stajyerEntities3 db = new stajyerEntities3();
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            tbl_user user = new tbl_user();

            user = db.tbl_user.Where(x => x.AD == txtAd.Text && x.SOYAD == txtSoyad.Text).FirstOrDefault();
            if (user != null)
            {
                user.KULLANICIADI = txtKullaniciAd.Text;
                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    user.PASSWORD = Sifreleme.SifreleAES(txtSifre.Text);

                    db.SaveChanges();
                    MessageBox.Show("Güncelleme Yapıldı");
                }
                else
                {
                    MessageBox.Show("Şifreler Aynı Değil");
                }
            }
            else
            {
                MessageBox.Show("Ad Veya Soyadınızı Doğru Giriniz!!!");
            }
        }
    }
}
