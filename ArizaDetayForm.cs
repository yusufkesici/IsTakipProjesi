using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garantiTakip
{
    public partial class ArizaDetayForm : Form
    {
        ArızaAnaForm Form;
        public ArizaDetayForm(ArızaAnaForm form)
        {
            Form = form;
            InitializeComponent();
        }
        stajyerEntities3 db = new stajyerEntities3();
        private void ArizaDetayForm_Load(object sender, EventArgs e)
        {
            foreach (tbl_personel item in db.tbl_personel)
            {
                comboPersonel.Items.Add(item.PERSONELAD + " " + item.PERSONELSOYAD);
            }

            tbl_Ariza ariza = db.tbl_Ariza.Find(Form.id);

            txtMusteriAd.Text = ariza.MusteriAd;
            txtMusteriSoyad.Text = ariza.MusteriSoyad;
            txtTel.Text = ariza.MusteriTelefon;
            txtOnarimSuresi.Text = ariza.OnarimSüresi;
            txtAdres.Text = ariza.MusteriAdres;
            txtArizaTanim.Text = ariza.ArızaTanim;
            comboAldigiHizmet.Text = ariza.MusteriAldigiHizmet;
            comboPersonel.Text = ariza.tbl_personel.PERSONELAD + " " + ariza.tbl_personel.PERSONELSOYAD;
            comboTür.Text = ariza.ArizaTür;
            comboUrunTür.Text = ariza.UrunTuru;
           
            arizaKayıt.Text = ariza.ArizaKayitTarih.ToString();
            
        }
       
        private void btnSil_Click(object sender, EventArgs e)
        {
            tbl_Ariza ariza = db.tbl_Ariza.Find(Form.id);
          


            DialogResult dialogResult = MessageBox.Show("Arıza Kaydı Silinecek Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                db.tbl_Ariza.Remove(ariza);

                // Seçilen Arıza Kaydı cariID si varsa hata verir
                db.SaveChanges();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }



           Form.Listele();

           
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            tbl_Ariza ariza = db.tbl_Ariza.Find(Form.id);


            

            ariza.MusteriAd = txtMusteriAd.Text;
            ariza.MusteriSoyad = txtMusteriSoyad.Text;
            ariza.MusteriTelefon = txtTel.Text;
            ariza.OnarimSüresi = txtOnarimSuresi.Text;
            ariza.MusteriAdres = txtAdres.Text;
            ariza.ArızaTanim = txtArizaTanim.Text;
            ariza.MusteriAldigiHizmet = comboAldigiHizmet.Text;

            tbl_personel personel = db.tbl_personel.Where(x => x.PERSONELAD + " " + x.PERSONELSOYAD == comboPersonel.Text).FirstOrDefault();
            ariza.PersonelID = personel.IND;


            ariza.ArizaTür = comboTür.Text;
            ariza.UrunTuru = comboUrunTür.Text;
           
            ariza.ArizaKayitTarih = Convert.ToDateTime(arizaKayıt.Text);
            
            db.SaveChanges();
            MessageBox.Show("Arıza Kaydı Güncellendi");
            Form.Listele();
        }
    }
}
